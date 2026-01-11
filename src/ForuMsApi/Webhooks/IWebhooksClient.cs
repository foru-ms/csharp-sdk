namespace ForuMsApi;

public partial interface IWebhooksClient
{
    Task<GetWebhooksResponse> ListAllWebhooksAsync(
        GetWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostWebhooksResponse> CreateAWebhookAsync(
        PostWebhooksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetWebhooksIdResponse> GetAWebhookAsync(
        GetWebhooksIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteWebhooksIdResponse> DeleteAWebhookAsync(
        DeleteWebhooksIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetWebhooksIdDeliveriesResponse> ListWebhookDeliveriesAsync(
        GetWebhooksIdDeliveriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetWebhooksIdDeliveriesSubIdResponse> GetADeliveryFromWebhookAsync(
        GetWebhooksIdDeliveriesSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteWebhooksIdDeliveriesSubIdResponse> DeleteADeliveryFromWebhookAsync(
        DeleteWebhooksIdDeliveriesSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
