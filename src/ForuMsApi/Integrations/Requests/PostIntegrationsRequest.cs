using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostIntegrationsRequest
{
    /// <summary>
    /// Integration type (e.g. slack, discord)
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// JSON configuration
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, object?> Config { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
