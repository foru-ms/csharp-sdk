using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListTeamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "handle": "handle",
                "members": [
                  {
                    "id": "id",
                    "email": "email",
                    "role": "MEMBER",
                    "status": "PENDING"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/team")
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

        var response = await Client.Provisioning.ListTeamAsync(
            new ListTeamProvisioningRequest
            {
                Handle = "handle",
                ProvisioningKey = "x-provisioning-key",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ListTeamProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
