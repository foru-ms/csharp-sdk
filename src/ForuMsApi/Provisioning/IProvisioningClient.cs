namespace ForuMsApi;

public partial interface IProvisioningClient
{
    /// <summary>
    /// Retrieve all instances owned by the authenticated user. Use the `handle` query parameter to get a single instance with its API key.
    /// </summary>
    Task<ListProvisioningResponse> ListAsync(
        ListProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new forum instance. Returns the instance details including the API key for accessing the forum API.
    /// </summary>
    Task<CreateProvisioningResponse> CreateAsync(
        CreateInstance request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an instance's name or handle. The `handle` field identifies which instance to update.
    /// </summary>
    Task<UpdateProvisioningResponse> UpdateAsync(
        UpdateInstance request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete an instance. This action cannot be undone.
    /// </summary>
    Task<DeleteProvisioningResponse> DeleteAsync(
        DeleteInstance request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve billing and subscription information for an instance.
    /// </summary>
    Task<GetBillingProvisioningResponse> GetBillingAsync(
        GetBillingProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change an instance's subscription plan. Returns a checkout URL for upgrades or a billing portal URL for downgrades.
    /// </summary>
    Task<ChangePlanProvisioningResponse> ChangePlanAsync(
        UpgradeInstance request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate a new API key for the instance. The old key will be invalidated.
    /// </summary>
    Task<RegenerateApiKeyProvisioningResponse> RegenerateApiKeyAsync(
        RegenerateApiKeyProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve usage statistics for an instance including API requests, storage, and content counts.
    /// </summary>
    Task<GetUsageProvisioningResponse> GetUsageAsync(
        GetUsageProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve all team members for an instance.
    /// </summary>
    Task<ListTeamProvisioningResponse> ListTeamAsync(
        ListTeamProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Invite new team members to an instance.
    /// </summary>
    Task<InviteTeamProvisioningResponse> InviteTeamAsync(
        InviteTeamProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a team member from an instance.
    /// </summary>
    Task<RemoveTeamMemberProvisioningResponse> RemoveTeamMemberAsync(
        RemoveTeamMemberProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve all custom domains for an instance.
    /// </summary>
    Task<ListDomainsProvisioningResponse> ListDomainsAsync(
        ListDomainsProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a custom domain to an instance.
    /// </summary>
    Task<AddDomainProvisioningResponse> AddDomainAsync(
        AddDomainProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a custom domain from an instance.
    /// </summary>
    Task<RemoveDomainProvisioningResponse> RemoveDomainAsync(
        RemoveDomainProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Export all data from an instance including threads, posts, users, tags, etc.
    /// </summary>
    Task<ExportDataProvisioningResponse> ExportDataAsync(
        ExportDataProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve all webhooks configured for an instance.
    /// </summary>
    Task<ListWebhooksProvisioningResponse> ListWebhooksAsync(
        ListWebhooksProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new webhook for an instance.
    /// </summary>
    Task<CreateWebhookProvisioningResponse> CreateWebhookAsync(
        CreateWebhookProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing webhook.
    /// </summary>
    Task<UpdateWebhookProvisioningResponse> UpdateWebhookAsync(
        UpdateWebhookProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a webhook from an instance.
    /// </summary>
    Task<DeleteWebhookProvisioningResponse> DeleteWebhookAsync(
        DeleteWebhookProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve owner and creator information for an instance.
    /// </summary>
    Task<GetOwnershipProvisioningResponse> GetOwnershipAsync(
        GetOwnershipProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Transfer instance ownership to another user. Only the current owner can transfer ownership.
    /// </summary>
    Task<TransferOwnershipProvisioningResponse> TransferOwnershipAsync(
        TransferOwnershipProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new account and receive a provisioning key for API access. Use this key to create and manage instances.
    /// </summary>
    Task<RegisterProvisioningResponse> RegisterAsync(
        RegisterProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Login with email and password to retrieve your provisioning key.
    /// </summary>
    Task<LoginProvisioningResponse> LoginAsync(
        LoginProvisioningRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
