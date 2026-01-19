using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class AddDomainTest : BaseMockServerTest
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
                "id": "id",
                "name": "name",
                "subdomain": "subdomain",
                "createdAt": "2024-01-15T09:30:00.000Z"
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
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.AddDomainAsync(
            new AddDomainProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Name = "name",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<AddDomainProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
