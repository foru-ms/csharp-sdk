using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class RetrievePostTest_ : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "parentId": "parentId",
                "userId": "userId",
                "body": "body",
                "depth": 1,
                "user": {
                  "id": "id",
                  "username": "username",
                  "displayName": "displayName"
                },
                "_count": {
                  "reactions": 1.1,
                  "children": 1.1
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
                    .WithPath("/posts/id/posts/subId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Posts.RetrievePostAsync(
            new RetrievePostPostsRequest { Id = "id", SubId = "subId" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RetrievePostPostsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
