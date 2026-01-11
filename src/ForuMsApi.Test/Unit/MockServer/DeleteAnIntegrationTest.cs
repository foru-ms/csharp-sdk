using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class DeleteAnIntegrationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "success": true
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/integrations/id").UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Integrations.DeleteAnIntegrationAsync(
            new DeleteIntegrationsIdRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DeleteIntegrationsIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
