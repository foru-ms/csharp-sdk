using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetAPostFromThreadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {}
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/threads/id/posts/subId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Threads.GetAPostFromThreadAsync(
            new GetThreadsIdPostsSubIdRequest { Id = "id", SubId = "subId" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetThreadsIdPostsSubIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
