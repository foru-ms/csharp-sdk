using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class RegisterTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "username": "username",
              "email": "email",
              "password": "password"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "token": "token",
                "user": {
                  "id": "id",
                  "username": "username",
                  "email": "email",
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/auth/register")
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

        var response = await Client.Auth.RegisterAsync(
            new RegisterAuthRequest
            {
                Username = "username",
                Email = "email",
                Password = "password",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RegisterResponse>(mockResponse)).UsingDefaults()
        );
    }
}
