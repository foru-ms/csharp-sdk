using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class TransferOwnershipTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "newOwnerEmail": "newOwnerEmail"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "message": "message",
                "instanceId": "instanceId",
                "newOwner": {
                  "id": "id",
                  "email": "email"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/ownership")
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

        var response = await Client.Provisioning.TransferOwnershipAsync(
            new TransferOwnershipProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                NewOwnerEmail = "newOwnerEmail",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TransferOwnershipProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
