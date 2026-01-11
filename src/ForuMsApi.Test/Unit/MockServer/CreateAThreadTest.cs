using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAThreadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "title": "title",
              "body": "body"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "title": "title",
                "body": "body",
                "userId": "userId",
                "tags": [
                  "tags"
                ],
                "poll": {
                  "title": "title",
                  "options": [
                    {
                      "title": "title"
                    }
                  ]
                },
                "id": "id",
                "slug": "slug",
                "locked": true,
                "pinned": true,
                "views": 1,
                "postsCount": 1,
                "lastPostAt": "lastPostAt",
                "extendedData": {
                  "key": "value"
                },
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/threads")
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

        var response = await Client.Threads.CreateAThreadAsync(
            new PostThreadsRequest { Title = "title", Body = "body" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostThreadsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
