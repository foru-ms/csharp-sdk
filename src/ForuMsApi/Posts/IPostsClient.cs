namespace ForuMsApi;

public partial interface IPostsClient
{
    Task<GetPostsResponse> ListAllPostsAsync(
        GetPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostPostsResponse> CreateAPostAsync(
        PostPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPostsIdResponse> GetAPostAsync(
        GetPostsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeletePostsIdResponse> DeleteAPostAsync(
        DeletePostsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchPostsIdResponse> UpdateAPostAsync(
        PatchPostsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPostsIdReactionsResponse> ListPostReactionsAsync(
        GetPostsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostPostsIdReactionsResponse> CreateAReactionInPostAsync(
        PostPostsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the authenticated user's reaction. No subId needed.
    /// </summary>
    Task<DeletePostsIdReactionsResponse> RemoveYourReactionFromPostAsync(
        DeletePostsIdReactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPostsIdReactionsSubIdResponse> GetAReactionFromPostAsync(
        GetPostsIdReactionsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeletePostsIdReactionsSubIdResponse> DeleteAReactionFromPostAsync(
        DeletePostsIdReactionsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPostsIdPostsResponse> ListPostPostsAsync(
        GetPostsIdPostsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPostsIdPostsSubIdResponse> GetAPostFromPostAsync(
        GetPostsIdPostsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeletePostsIdPostsSubIdResponse> DeleteAPostFromPostAsync(
        DeletePostsIdPostsSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
