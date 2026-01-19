using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record CreatePollThreadsRequest
{
    /// <summary>
    /// Thread ID
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Poll question/title
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Poll options (2-20)
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<CreatePollThreadsRequestOptionsItem> Options { get; set; } =
        new List<CreatePollThreadsRequestOptionsItem>();

    /// <summary>
    /// Optional expiration time
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Additional custom data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
