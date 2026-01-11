using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllWebhooksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/webhooks").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Webhooks.ListAllWebhooksAsync(new GetWebhooksRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetWebhooksResponse>(mockResponse)).UsingDefaults()
        );
    }
}
