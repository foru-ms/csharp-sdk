using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record ThreadListResponseDataItemsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Thread title
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Thread content (Markdown supported)
    /// </summary>
    [JsonPropertyName("body")]
    public required string Body { get; set; }

    /// <summary>
    /// Author user ID (required for API key auth, ignored for JWT auth)
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// List of tag slugs, names, or IDs to attach
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    /// <summary>
    /// Poll data
    /// </summary>
    [JsonPropertyName("poll")]
    public ThreadListResponseDataItemsItemPoll? Poll { get; set; }

    /// <summary>
    /// Whether thread is locked
    /// </summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Whether thread is pinned
    /// </summary>
    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    /// <summary>
    /// Custom metadata
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// URL-friendly identifier
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    /// <summary>
    /// View count
    /// </summary>
    [JsonPropertyName("views")]
    public required int Views { get; set; }

    /// <summary>
    /// Number of posts/replies
    /// </summary>
    [JsonPropertyName("postsCount")]
    public required int PostsCount { get; set; }

    /// <summary>
    /// Timestamp of the last post
    /// </summary>
    [JsonPropertyName("lastPostAt")]
    public string? LastPostAt { get; set; }

    /// <summary>
    /// Thread reactions
    /// </summary>
    [JsonPropertyName("reactions")]
    public IEnumerable<ThreadListResponseDataItemsItemReactionsItem>? Reactions { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
