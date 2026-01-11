using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Thread ID to post in
    /// </summary>
    [JsonPropertyName("threadId")]
    public required string ThreadId { get; set; }

    /// <summary>
    /// Post content (Markdown supported)
    /// </summary>
    [JsonPropertyName("body")]
    public required string Body { get; set; }

    /// <summary>
    /// Author user ID (required for API key auth, ignored for JWT auth)
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// Parent post ID for threading
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

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
