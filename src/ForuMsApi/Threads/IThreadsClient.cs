namespace ForuMsApi;

public partial interface IThreadsClient
{
    /// <summary>
    /// Retrieve a paginated list of threads. Use cursor for pagination.
    /// </summary>
    Task<ThreadListResponse> ListAsync(
        ListThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new thread.
    /// </summary>
    Task<ThreadResponse> CreateAsync(
        CreateThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a thread by ID or slug (if supported).
    /// </summary>
    Task<ThreadResponse> RetrieveAsync(
        RetrieveThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a thread.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing thread. Only provided fields will be modified.
    /// </summary>
    Task<UpdateThreadsResponse> UpdateAsync(
        UpdateThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of posts for Thread.
    /// </summary>
    Task<ThreadPostListResponse> ListPostsAsync(
        ListPostsThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrievePostThreadsResponse> RetrievePostAsync(
        RetrievePostThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeletePostAsync(
        DeletePostThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of reactions for Thread.
    /// </summary>
    Task<ThreadReactionListResponse> ListReactionsAsync(
        ListReactionsThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a Reaction in Thread.
    /// </summary>
    Task<ThreadReactionResponse> CreateReactionAsync(
        CreateReactionThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteReactionAsync(
        DeleteReactionThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveReactionThreadsResponse> RetrieveReactionAsync(
        RetrieveReactionThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of subscribers for Thread.
    /// </summary>
    Task<ThreadSubscriberListResponse> ListSubscribersAsync(
        ListSubscribersThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveSubscriberThreadsResponse> RetrieveSubscriberAsync(
        RetrieveSubscriberThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteSubscriberAsync(
        DeleteSubscriberThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<ThreadPollResponse> RetrievePollAsync(
        RetrievePollThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<ThreadPollResponse> CreatePollAsync(
        CreatePollThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<ThreadPollResponse> UpdatePollAsync(
        UpdatePollThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
