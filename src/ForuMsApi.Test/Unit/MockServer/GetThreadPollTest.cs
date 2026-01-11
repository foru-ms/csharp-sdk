using ForuMsApi;
using ForuMsApi.Core;
using NUnit.Framework;

namespace ForuMsApi.Test.Unit.MockServer;

[TestFixture]
public class GetThreadPollTest : BaseMockServerTest
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
                WireMock.RequestBuilders.Request.Create().WithPath("/threads/id/poll").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Threads.GetThreadPollAsync(
            new GetThreadsIdPollRequest { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GetThreadsIdPollResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
