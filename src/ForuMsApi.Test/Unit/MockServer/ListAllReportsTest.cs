using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "type": "type",
                  "description": "description",
                  "userId": "userId",
                  "reportedId": "reportedId",
                  "threadId": "threadId",
                  "postId": "postId",
                  "privateMessageId": "privateMessageId",
                  "id": "id",
                  "status": "status",
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
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/reports").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Reports.ListAllReportsAsync(new GetReportsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetReportsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
