using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class InviteTeamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "members": [
                {
                  "email": "email"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "invited": [
                  "invited"
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances/team")
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

        var response = await Client.Provisioning.InviteTeamAsync(
            new InviteTeamProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Members = new List<InviteTeamProvisioningRequestMembersItem>()
                {
                    new InviteTeamProvisioningRequestMembersItem { Email = "email" },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InviteTeamProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
