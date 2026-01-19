using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreatePollTest : BaseMockServerTest
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
              "data": {
                "id": "id",
                "title": "title",
                "options": [
                  {
                    "id": "id",
                    "title": "title",
                    "color": null
                  }
                ],
                "createdAt": "createdAt"
              }
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

        var response = await Client.Threads.CreatePollAsync(
            new CreatePollThreadsRequest
            {
                Id = "id",
                Title = "title",
                Options = new List<CreatePollThreadsRequestOptionsItem>()
                {
                    new CreatePollThreadsRequestOptionsItem { Title = "title" },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ThreadPollResponse>(mockResponse)).UsingDefaults()
        );
    }
}
