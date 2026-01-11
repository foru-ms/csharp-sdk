using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAReactionInThreadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "type": "LIKE"
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
                    .WithPath("/threads/id/reactions")
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

        var response = await Client.Threads.CreateAReactionInThreadAsync(
            new PostThreadsIdReactionsRequest
            {
                Id = "id",
                Type = PostThreadsIdReactionsRequestType.Like,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostThreadsIdReactionsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
