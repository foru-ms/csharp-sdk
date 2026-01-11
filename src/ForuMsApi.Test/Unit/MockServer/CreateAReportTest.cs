using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAReportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "type": "type"
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/reports")
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

        var response = await Client.Reports.CreateAReportAsync(
            new PostReportsRequest { Type = "type" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostReportsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
