using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListTest_ : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "instances": [
                  {
                    "id": "id",
                    "name": "name",
                    "handle": "handle",
                    "createdAt": "2024-01-15T09:30:00.000Z"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances")
                    .WithHeader("x-provisioning-key", "x-provisioning-key")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.ListAsync(
            new ListProvisioningRequest { ProvisioningKey = "x-provisioning-key" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ListProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
