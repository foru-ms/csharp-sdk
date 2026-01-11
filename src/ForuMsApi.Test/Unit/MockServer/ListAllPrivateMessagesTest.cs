using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class ListAllPrivateMessagesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "meta": {
                "total": 1,
                "page": 1,
                "limit": 1
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/private-messages").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PrivateMessages.ListAllPrivateMessagesAsync(
            new GetPrivateMessagesRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetPrivateMessagesResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
