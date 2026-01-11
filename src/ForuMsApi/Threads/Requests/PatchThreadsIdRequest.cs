using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PatchThreadsIdRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// New title
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// New content
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// Lock/unlock thread
    /// </summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Pin/unpin thread
    /// </summary>
    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    /// <summary>
    /// Update tags by slug, name, or ID
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    /// <summary>
    /// Update extended data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
