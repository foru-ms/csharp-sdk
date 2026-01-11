namespace ForuMsApi;

public partial interface ISsOsClient
{
    Task<GetSsoResponse> ListAllSsOsAsync(
        GetSsoRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostSsoResponse> CreateAnSsoAsync(
        PostSsoRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetSsoIdResponse> GetAnSsoAsync(
        GetSsoIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteSsoIdResponse> DeleteAnSsoAsync(
        DeleteSsoIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchSsoIdResponse> UpdateAnSsoAsync(
        PatchSsoIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
