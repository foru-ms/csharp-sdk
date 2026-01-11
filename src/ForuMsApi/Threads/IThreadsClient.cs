namespace ForuMsApi;

public partial interface IThreadsClient
{
    Task<GetThreadsResponse> ListAllThreadsAsync(
        GetThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostThreadsResponse> CreateAThreadAsync(
        PostThreadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdResponse> GetAThreadAsync(
        GetThreadsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteThreadsIdResponse> DeleteAThreadAsync(
        DeleteThreadsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchThreadsIdResponse> UpdateAThreadAsync(
        PatchThreadsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdPostsResponse> ListThreadPostsAsync(
        GetThreadsIdPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdPostsSubIdResponse> GetAPostFromThreadAsync(
        GetThreadsIdPostsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteThreadsIdPostsSubIdResponse> DeleteAPostFromThreadAsync(
        DeleteThreadsIdPostsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdReactionsResponse> ListThreadReactionsAsync(
        GetThreadsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostThreadsIdReactionsResponse> CreateAReactionInThreadAsync(
        PostThreadsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the authenticated user's reaction. No subId needed.
    /// </summary>
    Task<DeleteThreadsIdReactionsResponse> RemoveYourReactionFromThreadAsync(
        DeleteThreadsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdReactionsSubIdResponse> GetAReactionFromThreadAsync(
        GetThreadsIdReactionsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteThreadsIdReactionsSubIdResponse> DeleteAReactionFromThreadAsync(
        DeleteThreadsIdReactionsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdSubscribersResponse> ListThreadSubscribersAsync(
        GetThreadsIdSubscribersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdSubscribersSubIdResponse> GetASubscriberFromThreadAsync(
        GetThreadsIdSubscribersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteThreadsIdSubscribersSubIdResponse> DeleteASubscriberFromThreadAsync(
        DeleteThreadsIdSubscribersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetThreadsIdPollResponse> GetThreadPollAsync(
        GetThreadsIdPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostThreadsIdPollResponse> CreateThreadPollAsync(
        PostThreadsIdPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchThreadsIdPollResponse> UpdateThreadPollAsync(
        PatchThreadsIdPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
