using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class LoginTest_ : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "email": "email",
              "password": "password"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "provisioningKey": "provisioningKey",
                "userId": "userId",
                "email": "email"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/login")
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

        var response = await Client.Provisioning.LoginAsync(
            new LoginProvisioningRequest { Email = "email", Password = "password" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<LoginProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
