using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetCurrentUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "id",
              "username": "username"
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/auth/me").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Auth.GetCurrentUserAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetAuthMeResponse>(mockResponse)).UsingDefaults()
        );
    }
}
