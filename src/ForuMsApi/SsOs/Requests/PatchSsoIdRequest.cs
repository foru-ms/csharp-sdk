using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PatchSsoIdRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Provider name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Email domain to match
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }

    /// <summary>
    /// Enable/disable provider
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
