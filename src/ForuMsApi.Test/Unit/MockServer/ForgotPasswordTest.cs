using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ForgotPasswordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "message": "message",
                "resetToken": "resetToken"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/auth/forgot-password")
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

        var response = await Client.Auth.ForgotPasswordAsync(
            new ForgotPasswordAuthRequest { Email = "email" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ForgotPasswordResponse>(mockResponse)).UsingDefaults()
        );
    }
}
