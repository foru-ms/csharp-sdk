namespace ForuMsApi;

public partial interface IIntegrationsClient
{
    Task<GetIntegrationsResponse> ListAllIntegrationsAsync(
        GetIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostIntegrationsResponse> CreateAnIntegrationAsync(
        PostIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetIntegrationsIdResponse> GetAnIntegrationAsync(
        GetIntegrationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteIntegrationsIdResponse> DeleteAnIntegrationAsync(
        DeleteIntegrationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchIntegrationsIdResponse> UpdateAnIntegrationAsync(
        PatchIntegrationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
