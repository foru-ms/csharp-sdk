using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAReplyInPrivateMessageTest : BaseMockServerTest
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
              "data": {}
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/private-messages/id/replies")
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

        var response = await Client.PrivateMessages.CreateAReplyInPrivateMessageAsync(
            new PostPrivateMessagesIdRepliesRequest
            {
                Id = "id",
                RecipientId = "recipientId",
                Body = "body",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostPrivateMessagesIdRepliesResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
