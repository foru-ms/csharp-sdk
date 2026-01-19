using ForuMsApi.Core;

namespace ForuMsApi;

public partial class ForumClientClient : IForumClientClient
{
    private readonly RawClient _client;

    public ForumClientClient(string apiKey, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "x-api-key", apiKey },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "ForuMsApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Foru-ms.Sdk/0.0.33" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Auth = new AuthClient(_client);
        Search = new SearchClient(_client);
        Tags = new TagsClient(_client);
        Threads = new ThreadsClient(_client);
        Posts = new PostsClient(_client);
        PrivateMessages = new PrivateMessagesClient(_client);
        Users = new UsersClient(_client);
        Roles = new RolesClient(_client);
        Reports = new ReportsClient(_client);
        Notifications = new NotificationsClient(_client);
        Webhooks = new WebhooksClient(_client);
        Integrations = new IntegrationsClient(_client);
        SsOs = new SsOsClient(_client);
        Provisioning = new ProvisioningClient(_client);
    }

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
