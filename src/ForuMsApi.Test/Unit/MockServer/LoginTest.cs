using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class LoginTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "login": "login",
              "password": "password"
            }
            """;

        const string mockResponse = """
            {
              "token": "token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/auth/login")
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

        var response = await Client.Auth.LoginAsync(
            new PostAuthLoginRequest { Login = "login", Password = "password" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostAuthLoginResponse>(mockResponse)).UsingDefaults()
        );
    }
}
