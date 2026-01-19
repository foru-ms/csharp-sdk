namespace ForuMsApi;

public partial interface INotificationsClient
{
    /// <summary>
    /// Retrieve a paginated list of notifications. Use cursor for pagination.
    /// </summary>
    Task<NotificationListResponse> ListAsync(
        ListNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new notification.
    /// </summary>
    Task<NotificationResponse> CreateAsync(
        CreateNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a notification by ID or slug (if supported).
    /// </summary>
    Task<NotificationResponse> RetrieveAsync(
        RetrieveNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a notification.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing notification. Only provided fields will be modified.
    /// </summary>
    Task<UpdateNotificationsResponse> UpdateAsync(
        UpdateNotificationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
