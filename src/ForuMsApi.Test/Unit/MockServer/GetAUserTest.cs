using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetAUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/id").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.GetAUserAsync(new GetUsersIdRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetUsersIdResponse>(mockResponse)).UsingDefaults()
        );
    }
}
