using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

/// <summary>
/// OIDC provider config
/// </summary>
[Serializable]
public record SsoCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Provider name (e.g. Google)
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public required string ClientSecret { get; set; }

    [JsonPropertyName("issuer")]
    public required string Issuer { get; set; }

    [JsonPropertyName("authorizationEndpoint")]
    public required string AuthorizationEndpoint { get; set; }

    [JsonPropertyName("tokenEndpoint")]
    public required string TokenEndpoint { get; set; }

    [JsonPropertyName("userInfoEndpoint")]
    public required string UserInfoEndpoint { get; set; }

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
