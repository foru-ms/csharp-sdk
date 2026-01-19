namespace ForuMsApi;

public partial interface ISearchClient
{
    Task<SearchSearchResponse> SearchAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
