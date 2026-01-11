using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostAuthRegisterRequest
{
    /// <summary>
    /// Username
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// Display Name
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Password (min 8 chars)
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <summary>
    /// Roles
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<string>? Roles { get; set; }

    /// <summary>
    /// Bio
    /// </summary>
    [JsonPropertyName("bio")]
    public string? Bio { get; set; }

    /// <summary>
    /// Extended data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
