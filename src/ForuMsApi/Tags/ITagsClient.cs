namespace ForuMsApi;

public partial interface ITagsClient
{
    /// <summary>
    /// Retrieve a paginated list of tags. Use cursor for pagination.
    /// </summary>
    Task<TagListResponse> ListAsync(
        ListTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new tag.
    /// </summary>
    Task<TagResponse> CreateAsync(
        CreateTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a tag by ID or slug (if supported).
    /// </summary>
    Task<TagResponse> RetrieveAsync(
        RetrieveTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a tag.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing tag. Only provided fields will be modified.
    /// </summary>
    Task<UpdateTagsResponse> UpdateAsync(
        UpdateTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of subscribers for Tag.
    /// </summary>
    Task<TagSubscriberListResponse> ListSubscribersAsync(
        ListSubscribersTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveSubscriberTagsResponse> RetrieveSubscriberAsync(
        RetrieveSubscriberTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteSubscriberAsync(
        DeleteSubscriberTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
