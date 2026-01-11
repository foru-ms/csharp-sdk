using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAPrivateMessageTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "recipientId": "recipientId",
              "body": "body"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "recipientId": "recipientId",
                "senderId": "senderId",
                "title": "title",
                "body": "body",
                "parentId": "parentId",
                "extendedData": {
                  "key": "value"
                },
                "id": "id",
                "status": "status",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/private-messages")
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

        var response = await Client.PrivateMessages.CreateAPrivateMessageAsync(
            new PostPrivateMessagesRequest { RecipientId = "recipientId", Body = "body" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostPrivateMessagesResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
