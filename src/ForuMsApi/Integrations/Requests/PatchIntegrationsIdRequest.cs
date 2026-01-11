using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PatchIntegrationsIdRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Integration name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// JSON configuration (merged with existing)
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, object?>? Config { get; set; }

    /// <summary>
    /// Enable/disable integration
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
