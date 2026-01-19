namespace ForuMsApi;

public partial interface IPostsClient
{
    /// <summary>
    /// Retrieve a paginated list of posts. Use cursor for pagination.
    /// </summary>
    Task<PostListResponse> ListAsync(
        ListPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new post.
    /// </summary>
    Task<PostResponse> CreateAsync(
        CreatePostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a post by ID or slug (if supported).
    /// </summary>
    Task<PostResponse> RetrieveAsync(
        RetrievePostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a post.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeletePostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing post. Only provided fields will be modified.
    /// </summary>
    Task<UpdatePostsResponse> UpdateAsync(
        UpdatePostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of reactions for Post.
    /// </summary>
    Task<PostReactionListResponse> ListReactionsAsync(
        ListReactionsPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a Reaction in Post.
    /// </summary>
    Task<PostReactionResponse> CreateReactionAsync(
        CreateReactionPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteReactionAsync(
        DeleteReactionPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveReactionPostsResponse> RetrieveReactionAsync(
        RetrieveReactionPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of posts for Post.
    /// </summary>
    Task<PostPostListResponse> ListPostsAsync(
        ListPostsPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrievePostPostsResponse> RetrievePostAsync(
        RetrievePostPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeletePostAsync(
        DeletePostPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
