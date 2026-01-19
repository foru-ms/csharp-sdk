namespace ForuMsApi;

public partial interface IRolesClient
{
    /// <summary>
    /// Retrieve a paginated list of roles. Use cursor for pagination.
    /// </summary>
    Task<RoleListResponse> ListAsync(
        ListRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new role.
    /// </summary>
    Task<RoleResponse> CreateAsync(
        CreateRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a role by ID or slug (if supported).
    /// </summary>
    Task<RoleResponse> RetrieveAsync(
        RetrieveRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a role.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing role. Only provided fields will be modified.
    /// </summary>
    Task<UpdateRolesResponse> UpdateAsync(
        UpdateRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
