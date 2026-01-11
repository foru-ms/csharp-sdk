using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllThreadsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/threads").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Threads.ListAllThreadsAsync(new GetThreadsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetThreadsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
