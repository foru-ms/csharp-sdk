namespace ForuMsApi;

public partial interface IWebhooksClient
{
    /// <summary>
    /// Retrieve a paginated list of webhooks. Use cursor for pagination.
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<WebhookListResponse> ListAsync(
        ListWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new webhook.
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<WebhookResponse> CreateAsync(
        CreateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a webhook by ID or slug (if supported).
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<WebhookResponse> RetrieveAsync(
        RetrieveWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a webhook.
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing webhook. Only provided fields will be modified.
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<UpdateWebhooksResponse> UpdateAsync(
        UpdateWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of deliveries for Webhook.
    ///
    /// **Requires feature: webhooks**
    /// </summary>
    Task<WebhookDeliveryListResponse> ListDeliveriesAsync(
        ListDeliveriesWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<RetrieveDeliveryWebhooksResponse> RetrieveDeliveryAsync(
        RetrieveDeliveryWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<SuccessResponse> DeleteDeliveryAsync(
        DeleteDeliveryWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
