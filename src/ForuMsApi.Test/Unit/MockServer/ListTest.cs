using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "items": [
                  {
                    "name": "name",
                    "id": "id",
                    "createdAt": "createdAt",
                    "updatedAt": "updatedAt"
                  }
                ],
                "nextCursor": "nextCursor",
                "count": 1
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

        var response = await Client.Tags.ListAsync(new ListTagsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TagListResponse>(mockResponse)).UsingDefaults()
        );
    }
}
