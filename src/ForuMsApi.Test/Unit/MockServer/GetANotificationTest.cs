using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetANotificationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/notifications/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Notifications.GetANotificationAsync(
            new GetNotificationsIdRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetNotificationsIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
