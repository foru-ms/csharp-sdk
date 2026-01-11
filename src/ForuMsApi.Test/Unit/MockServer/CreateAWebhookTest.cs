using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name",
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
                "name": "name",
                "url": "url",
                "events": [
                  "events"
                ],
                "active": true,
                "lastTriggered": "lastTriggered",
                "failureCount": 1,
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/webhooks")
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

        var response = await Client.Webhooks.CreateAWebhookAsync(
            new PostWebhooksRequest
            {
                Name = "name",
                Url = "url",
                Events = new List<string>() { "events" },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostWebhooksResponse>(mockResponse)).UsingDefaults()
        );
    }
}
