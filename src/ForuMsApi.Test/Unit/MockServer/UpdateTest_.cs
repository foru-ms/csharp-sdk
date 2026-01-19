using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class UpdateTest_ : BaseMockServerTest
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
                "name": "name",
                "handle": "handle"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/provisioning/instances")
                    .WithHeader("x-provisioning-key", "x-provisioning-key")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Provisioning.UpdateAsync(
            new UpdateInstance { ProvisioningKey = "x-provisioning-key", Handle = "handle" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<UpdateProvisioningResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
