using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllNotificationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "id",
                  "userId": "userId",
                  "notifierId": "notifierId",
                  "type": "type",
                  "description": "description",
                  "status": "status",
                  "threadId": "threadId",
                  "postId": "postId",
                  "privateMessageId": "privateMessageId",
                  "extendedData": {
                    "key": "value"
                  },
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
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/notifications").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Notifications.ListAllNotificationsAsync(
            new GetNotificationsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetNotificationsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
