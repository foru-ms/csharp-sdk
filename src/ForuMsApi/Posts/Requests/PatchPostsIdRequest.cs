using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PatchPostsIdRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Updated post content
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// Move post to another thread
    /// </summary>
    [JsonPropertyName("threadId")]
    public string? ThreadId { get; set; }

    /// <summary>
    /// Change parent post
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

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
