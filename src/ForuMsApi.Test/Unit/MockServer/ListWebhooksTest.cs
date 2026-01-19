using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListWebhooksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "handle": "handle",
                "webhooks": [
                  {
                    "id": "id",
                    "url": "url",
                    "events": [
                      "events"
                    ],
                    "active": true
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/webhooks")
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

        var response = await Client.Provisioning.ListWebhooksAsync(
            new ListWebhooksProvisioningRequest
            {
                Handle = "handle",
                ProvisioningKey = "x-provisioning-key",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ListWebhooksProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
