namespace ForuMsApi;

public partial interface INotificationsClient
{
    Task<GetNotificationsResponse> ListAllNotificationsAsync(
        GetNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostNotificationsResponse> CreateANotificationAsync(
        PostNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetNotificationsIdResponse> GetANotificationAsync(
        GetNotificationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteNotificationsIdResponse> DeleteANotificationAsync(
        DeleteNotificationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchNotificationsIdResponse> UpdateANotificationAsync(
        PatchNotificationsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
