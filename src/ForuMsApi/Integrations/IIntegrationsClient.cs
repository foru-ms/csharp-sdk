namespace ForuMsApi;

public partial interface IIntegrationsClient
{
    /// <summary>
    /// Retrieve a paginated list of integrations. Use cursor for pagination.
    ///
    /// **Requires feature: integrations**
    /// </summary>
    Task<IntegrationListResponse> ListAsync(
        ListIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an new integration.
    ///
    /// **Requires feature: integrations**
    /// </summary>
    Task<IntegrationResponse> CreateAsync(
        CreateIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve an integration by ID or slug (if supported).
    ///
    /// **Requires feature: integrations**
    /// </summary>
    Task<IntegrationResponse> RetrieveAsync(
        RetrieveIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete an integration.
    ///
    /// **Requires feature: integrations**
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing integration. Only provided fields will be modified.
    ///
    /// **Requires feature: integrations**
    /// </summary>
    Task<UpdateIntegrationsResponse> UpdateAsync(
        UpdateIntegrationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
