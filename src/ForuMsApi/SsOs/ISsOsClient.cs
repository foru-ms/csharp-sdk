namespace ForuMsApi;

public partial interface ISsOsClient
{
    /// <summary>
    /// Retrieve a paginated list of ssos. Use cursor for pagination.
    ///
    /// **Requires feature: sso**
    /// </summary>
    Task<SsoListResponse> ListAsync(
        ListSsOsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an new sso.
    ///
    /// **Requires feature: sso**
    /// </summary>
    Task<SsoResponse> CreateAsync(
        CreateSsOsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve an sso by ID or slug (if supported).
    ///
    /// **Requires feature: sso**
    /// </summary>
    Task<SsoResponse> RetrieveAsync(
        RetrieveSsOsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete an sso.
    ///
    /// **Requires feature: sso**
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteSsOsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing sso. Only provided fields will be modified.
    ///
    /// **Requires feature: sso**
    /// </summary>
    Task<UpdateSsOsResponse> UpdateAsync(
        UpdateSsOsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
