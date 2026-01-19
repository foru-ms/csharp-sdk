using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class RemoveDomainTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "removed": "removed"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/domains")
                    .WithHeader("x-provisioning-key", "x-provisioning-key")
                    .WithHeader("Content-Type", "application/json")
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.RemoveDomainAsync(
            new RemoveDomainProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Name = "name",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoveDomainProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
