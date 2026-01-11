using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllUsersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "id",
                  "username": "username",
                  "displayName": "displayName",
                  "bio": "bio",
                  "signature": "signature",
                  "url": "url",
                  "postsCount": 1,
                  "threadsCount": 1,
                  "isOnline": true,
                  "lastSeenAt": "lastSeenAt",
                  "roles": [
                    {
                      "id": "id",
                      "name": "name",
                      "slug": null
                    }
                  ],
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
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.ListAllUsersAsync(new GetUsersRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetUsersResponse>(mockResponse)).UsingDefaults()
        );
    }
}
