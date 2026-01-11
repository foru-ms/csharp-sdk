using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAnSsoTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name",
              "clientId": "clientId",
              "clientSecret": "clientSecret",
              "issuer": "issuer",
              "authorizationEndpoint": "authorizationEndpoint",
              "tokenEndpoint": "tokenEndpoint",
              "userInfoEndpoint": "userInfoEndpoint"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "provider": "OKTA",
                "domain": "domain",
                "active": true,
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/sso")
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

        var response = await Client.SsOs.CreateAnSsoAsync(
            new PostSsoRequest
            {
                Name = "name",
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                Issuer = "issuer",
                AuthorizationEndpoint = "authorizationEndpoint",
                TokenEndpoint = "tokenEndpoint",
                UserInfoEndpoint = "userInfoEndpoint",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostSsoResponse>(mockResponse)).UsingDefaults()
        );
    }
}
