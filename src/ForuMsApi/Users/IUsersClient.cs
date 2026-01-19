namespace ForuMsApi;

public partial interface IUsersClient
{
    /// <summary>
    /// Retrieve a paginated list of users. Use cursor for pagination.
    /// </summary>
    Task<UserListResponse> ListAsync(
        ListUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new user.
    /// </summary>
    Task<UserResponse> CreateAsync(
        CreateUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a user by ID or slug (if supported).
    /// </summary>
    Task<UserResponse> RetrieveAsync(
        RetrieveUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a user.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing user. Only provided fields will be modified.
    /// </summary>
    Task<UpdateUsersResponse> UpdateAsync(
        UpdateUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of followers for User.
    /// </summary>
    Task<UserFollowerListResponse> ListFollowersAsync(
        ListFollowersUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveFollowerUsersResponse> RetrieveFollowerAsync(
        RetrieveFollowerUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteFollowerAsync(
        DeleteFollowerUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of following for User.
    /// </summary>
    Task<UserFollowingListResponse> ListFollowingAsync(
        ListFollowingUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveFollowingUsersResponse> RetrieveFollowingAsync(
        RetrieveFollowingUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteFollowingAsync(
        DeleteFollowingUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
