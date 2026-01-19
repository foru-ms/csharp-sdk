using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ResetPasswordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "password": "password"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "message": "message"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/auth/reset-password")
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

        var response = await Client.Auth.ResetPasswordAsync(
            new ResetPasswordAuthRequest { Password = "password" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ResetPasswordResponse>(mockResponse)).UsingDefaults()
        );
    }
}
