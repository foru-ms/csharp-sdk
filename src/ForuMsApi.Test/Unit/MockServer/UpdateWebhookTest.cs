using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class UpdateWebhookTest : BaseMockServerTest
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
                "id": "id",
                "url": "url",
                "events": [
                  "events"
                ],
                "active": true,
                "createdAt": "2024-01-15T09:30:00.000Z",
                "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.UpdateWebhookAsync(
            new UpdateWebhookProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                WebhookId = "webhookId",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<UpdateWebhookProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
