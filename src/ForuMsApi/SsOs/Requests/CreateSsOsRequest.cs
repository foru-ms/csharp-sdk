using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record CreateSsOsRequest
{
    /// <summary>
    /// SSO provider type
    /// </summary>
    [JsonPropertyName("provider")]
    public required CreateSsOsRequestProvider Provider { get; set; }

    /// <summary>
    /// Email domain to match (e.g. 'acme.com')
    /// </summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    /// <summary>
    /// Provider configuration (clientId, issuer, etc.)
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, object?> Config { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// Whether SSO is active
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Custom extended data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
