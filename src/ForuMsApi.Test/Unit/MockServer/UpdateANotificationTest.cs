using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class UpdateANotificationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/notifications/id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Notifications.UpdateANotificationAsync(
            new PatchNotificationsIdRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PatchNotificationsIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
