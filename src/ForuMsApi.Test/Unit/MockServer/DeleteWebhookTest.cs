using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class DeleteWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "webhookId": "webhookId"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "deleted": "deleted"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/webhooks")
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

        var response = await Client.Provisioning.DeleteWebhookAsync(
            new DeleteWebhookProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                WebhookId = "webhookId",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DeleteWebhookProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
