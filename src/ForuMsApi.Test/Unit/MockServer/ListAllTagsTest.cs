using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllTagsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/tags").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tags.ListAllTagsAsync(new GetTagsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetTagsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
