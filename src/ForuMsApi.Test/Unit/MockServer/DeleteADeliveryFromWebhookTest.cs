using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class DeleteADeliveryFromWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "success": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/webhooks/id/deliveries/subId")
                    .UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Webhooks.DeleteADeliveryFromWebhookAsync(
            new DeleteWebhooksIdDeliveriesSubIdRequest { Id = "id", SubId = "subId" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DeleteWebhooksIdDeliveriesSubIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
