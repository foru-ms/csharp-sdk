namespace ForuMsApi;

public partial interface IPrivateMessagesClient
{
    Task<GetPrivateMessagesResponse> ListAllPrivateMessagesAsync(
        GetPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostPrivateMessagesResponse> CreateAPrivateMessageAsync(
        PostPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPrivateMessagesIdResponse> GetAPrivateMessageAsync(
        GetPrivateMessagesIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeletePrivateMessagesIdResponse> DeleteAPrivateMessageAsync(
        DeletePrivateMessagesIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPrivateMessagesIdRepliesResponse> ListPrivateMessageRepliesAsync(
        GetPrivateMessagesIdRepliesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostPrivateMessagesIdRepliesResponse> CreateAReplyInPrivateMessageAsync(
        PostPrivateMessagesIdRepliesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetPrivateMessagesIdRepliesSubIdResponse> GetAReplyFromPrivateMessageAsync(
        GetPrivateMessagesIdRepliesSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeletePrivateMessagesIdRepliesSubIdResponse> DeleteAReplyFromPrivateMessageAsync(
        DeletePrivateMessagesIdRepliesSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
