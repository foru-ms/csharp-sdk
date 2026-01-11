using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostWebhooksRequest
{
    /// <summary>
    /// Webhook name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Target URL
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// List of event types (e.g. post.created)
    /// </summary>
    [JsonPropertyName("events")]
    public IEnumerable<string> Events { get; set; } = new List<string>();

    /// <summary>
    /// Secret for signature verification (auto-generated if missing)
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
