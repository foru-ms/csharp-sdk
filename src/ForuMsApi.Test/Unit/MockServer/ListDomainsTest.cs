using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListDomainsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "handle": "handle",
                "domains": [
                  {
                    "id": "id",
                    "name": "name",
                    "createdAt": "2024-01-15T09:30:00.000Z"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/domains")
                    .WithParam("handle", "handle")
                    .WithHeader("x-provisioning-key", "x-provisioning-key")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.ListDomainsAsync(
            new ListDomainsProvisioningRequest
            {
                Handle = "handle",
                ProvisioningKey = "x-provisioning-key",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ListDomainsProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
