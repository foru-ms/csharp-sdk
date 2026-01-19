using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class SearchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "items": [
                  {
                    "type": "thread",
                    "id": "id"
                  }
                ],
                "nextCursor": "nextCursor",
                "hasMore": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/search/").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Search.SearchAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<SearchSearchResponse>(mockResponse)).UsingDefaults()
        );
    }
}
