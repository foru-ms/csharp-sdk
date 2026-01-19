using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ChangePlanTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "plan": "FREE"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "action": "checkout",
                "plan": "plan",
                "isAnnual": true,
                "message": "message",
                "url": "url"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/billing")
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

        var response = await Client.Provisioning.ChangePlanAsync(
            new UpgradeInstance
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Plan = UpgradeInstancePlan.Free,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ChangePlanProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
