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
              "token": "token"
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
            new PostAuthRegisterRequest
            {
                Username = "username",
                Email = "email",
                Password = "password",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostAuthRegisterResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
