namespace ForuMsApi;

public partial interface IForuMsApiClient
{
    public AuthClient Auth { get; }
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
}
