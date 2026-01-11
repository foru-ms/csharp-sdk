using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetAPrivateMessageTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithPath("/private-messages/id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PrivateMessages.GetAPrivateMessageAsync(
            new GetPrivateMessagesIdRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetPrivateMessagesIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
