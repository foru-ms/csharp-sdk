using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetOwnershipTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "handle": "handle",
                "owner": {
                  "id": "id",
                  "email": "email",
                  "name": "name"
                },
                "creator": {
                  "id": "id",
                  "email": "email",
                  "name": "name"
                },
                "isCurrentUserOwner": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/ownership")
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

        var response = await Client.Provisioning.GetOwnershipAsync(
            new GetOwnershipProvisioningRequest
            {
                Handle = "handle",
                ProvisioningKey = "x-provisioning-key",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetOwnershipProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
