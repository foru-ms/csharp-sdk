using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class CreateAReactionInPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "type": "LIKE"
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
                    .WithPath("/posts/id/reactions")
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

        var response = await Client.Posts.CreateAReactionInPostAsync(
            new PostPostsIdReactionsRequest
            {
                Id = "id",
                Type = PostPostsIdReactionsRequestType.Like,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PostPostsIdReactionsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
