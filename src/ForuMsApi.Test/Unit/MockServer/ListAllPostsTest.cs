using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllPostsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/posts").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Posts.ListAllPostsAsync(new GetPostsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetPostsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
