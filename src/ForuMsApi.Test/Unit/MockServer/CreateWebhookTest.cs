using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "url": "url",
              "events": [
                "events"
              ]
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
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.CreateWebhookAsync(
            new CreateWebhookProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Url = "url",
                Events = new List<string>() { "events" },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CreateWebhookProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
