using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAnIntegrationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "type": "type",
              "config": {
                "key": "value"
              }
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "type": "SLACK",
                "name": "name",
                "active": true,
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/integrations")
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

        var response = await Client.Integrations.CreateAnIntegrationAsync(
            new PostIntegrationsRequest
            {
                Type = "type",
                Config = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostIntegrationsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
