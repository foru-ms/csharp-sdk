using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record LoginAuthRequest
{
    /// <summary>
    /// Username or Email
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
