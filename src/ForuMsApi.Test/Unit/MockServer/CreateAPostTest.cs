using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "threadId": "threadId",
              "body": "body"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "threadId": "threadId",
                "body": "body",
                "userId": "userId",
                "parentId": "parentId",
                "extendedData": {
                  "key": "value"
                },
                "id": "id",
                "depth": 1,
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/posts")
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

        var response = await Client.Posts.CreateAPostAsync(
            new PostPostsRequest { ThreadId = "threadId", Body = "body" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostPostsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
