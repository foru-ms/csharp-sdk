using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetBillingTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "instanceId": "instanceId",
                "handle": "handle",
                "plan": "FREE",
                "status": "status",
                "currentPeriodEnd": "2024-01-15T09:30:00.000Z",
                "cancelAtPeriodEnd": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/billing")
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

        var response = await Client.Provisioning.GetBillingAsync(
            new GetBillingProvisioningRequest
            {
                Handle = "handle",
                ProvisioningKey = "x-provisioning-key",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetBillingProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
