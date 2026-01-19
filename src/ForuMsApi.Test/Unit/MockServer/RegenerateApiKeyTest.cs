using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class RegenerateApiKeyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "handle": "handle",
                "apiKey": "apiKey"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/api-key")
                    .WithHeader("x-provisioning-key", "x-provisioning-key")
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

        var response = await Client.Provisioning.RegenerateApiKeyAsync(
            new RegenerateApiKeyProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RegenerateApiKeyProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
