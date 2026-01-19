namespace ForuMsApi;

public partial interface IForumClientClient
{
    public AuthClient Auth { get; }
    public SearchClient Search { get; }
    public TagsClient Tags { get; }
    public ThreadsClient Threads { get; }
    public PostsClient Posts { get; }
    public PrivateMessagesClient PrivateMessages { get; }
    public UsersClient Users { get; }
    public RolesClient Roles { get; }
    public ReportsClient Reports { get; }
    public NotificationsClient Notifications { get; }
    public WebhooksClient Webhooks { get; }
    public IntegrationsClient Integrations { get; }
    public SsOsClient SsOs { get; }
    public ProvisioningClient Provisioning { get; }
}
