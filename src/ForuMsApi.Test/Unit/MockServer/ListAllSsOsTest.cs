using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllSsOsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "id",
                  "provider": "OKTA",
                  "domain": "domain",
                  "active": true,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/sso").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SsOs.ListAllSsOsAsync(new GetSsoRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetSsoResponse>(mockResponse)).UsingDefaults()
        );
    }
}
