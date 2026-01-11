using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateThreadPollTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "title": "title",
              "options": [
                {
                  "title": "title"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "data": {}
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/threads/id/poll")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Threads.CreateThreadPollAsync(
            new PostThreadsIdPollRequest
            {
                Id = "id",
                Title = "title",
                Options = new List<PostThreadsIdPollRequestOptionsItem>()
                {
                    new PostThreadsIdPollRequestOptionsItem { Title = "title" },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostThreadsIdPollResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
