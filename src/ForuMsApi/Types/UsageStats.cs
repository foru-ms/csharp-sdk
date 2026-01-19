using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record UsageStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    [JsonPropertyName("period")]
    public required string Period { get; set; }

    [JsonPropertyName("apiRequests")]
    public required int ApiRequests { get; set; }

    [JsonPropertyName("storageBytes")]
    public required int StorageBytes { get; set; }

    [JsonPropertyName("members")]
    public required int Members { get; set; }

    [JsonPropertyName("forumUsers")]
    public required int ForumUsers { get; set; }

    [JsonPropertyName("threads")]
    public required int Threads { get; set; }

    [JsonPropertyName("posts")]
    public required int Posts { get; set; }

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
