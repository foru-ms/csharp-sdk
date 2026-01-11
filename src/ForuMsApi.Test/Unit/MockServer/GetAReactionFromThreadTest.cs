using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetAReactionFromThreadTest : BaseMockServerTest
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
                    .WithPath("/threads/id/reactions/subId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Threads.GetAReactionFromThreadAsync(
            new GetThreadsIdReactionsSubIdRequest { Id = "id", SubId = "subId" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetThreadsIdReactionsSubIdResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
