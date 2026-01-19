using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateReactionTest : BaseMockServerTest
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
              "data": {
                "id": "id",
                "type": "type",
                "userId": "userId",
                "user": {
                  "id": "id",
                  "username": "username",
                  "displayName": "displayName"
                },
                "createdAt": "createdAt"
              }
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

        var response = await Client.Threads.CreateReactionAsync(
            new CreateReactionThreadsRequest
            {
                Id = "id",
                Type = CreateReactionThreadsRequestType.Like,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ThreadReactionResponse>(mockResponse)).UsingDefaults()
        );
    }
}
