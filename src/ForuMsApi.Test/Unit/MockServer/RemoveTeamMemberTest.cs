using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class RemoveTeamMemberTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "handle": "handle",
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "removed": "removed"
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
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.RemoveTeamMemberAsync(
            new RemoveTeamMemberProvisioningRequest
            {
                ProvisioningKey = "x-provisioning-key",
                Handle = "handle",
                Email = "email",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoveTeamMemberProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
