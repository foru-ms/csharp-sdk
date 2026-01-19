using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListDeliveriesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "items": [
                  {
                    "id": "id",
                    "webhookId": "webhookId",
                    "event": "event",
                    "payload": null,
                    "responseCode": null,
                    "responseBody": null,
                    "success": true,
                    "error": null,
                    "createdAt": "createdAt"
                  }
                ],
                "nextCursor": "nextCursor",
                "count": 1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/webhooks/id/deliveries")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Webhooks.ListDeliveriesAsync(
            new ListDeliveriesWebhooksRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<WebhookDeliveryListResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
