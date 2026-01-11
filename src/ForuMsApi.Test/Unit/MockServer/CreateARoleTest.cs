using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateARoleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "name": "name",
                "slug": "slug",
                "description": "description",
                "color": "color",
                "extendedData": {
                  "key": "value"
                },
                "id": "id",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/roles")
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

        var response = await Client.Roles.CreateARoleAsync(new PostRolesRequest { Name = "name" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostRolesResponse>(mockResponse)).UsingDefaults()
        );
    }
}
