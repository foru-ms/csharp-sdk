using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ExportDataTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "summary": {
                  "handle": "handle",
                  "name": "name",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "counts": {
                    "key": 1.1
                  }
                },
                "export": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/export")
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

        var response = await Client.Provisioning.ExportDataAsync(
            new ExportDataProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExportDataProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
