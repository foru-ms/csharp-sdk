namespace ForuMsApi;

public partial interface IPrivateMessagesClient
{
    /// <summary>
    /// Retrieve a paginated list of private messages. Use cursor for pagination.
    /// </summary>
    Task<PrivateMessageListResponse> ListAsync(
        ListPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new private message.
    /// </summary>
    Task<PrivateMessageResponse> CreateAsync(
        CreatePrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a private message by ID or slug (if supported).
    /// </summary>
    Task<PrivateMessageResponse> RetrieveAsync(
        RetrievePrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a private message.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeletePrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing private message. Only provided fields will be modified.
    /// </summary>
    Task<UpdatePrivateMessagesResponse> UpdateAsync(
        UpdatePrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of replies for Private Message.
    /// </summary>
    Task<PrivateMessageReplyListResponse> ListRepliesAsync(
        ListRepliesPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a Reply in Private Message.
    /// </summary>
    Task<PrivateMessageReplyResponse> CreateReplyAsync(
        CreateReplyPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveReplyPrivateMessagesResponse> RetrieveReplyAsync(
        RetrieveReplyPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteReplyAsync(
        DeleteReplyPrivateMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
