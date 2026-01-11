using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostAuthResetPasswordRequest
{
    /// <summary>
    /// New Password (min 8 chars)
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <summary>
    /// Old Password (for change password)
    /// </summary>
    [JsonPropertyName("oldPassword")]
    public string? OldPassword { get; set; }

    /// <summary>
    /// Email (required if using oldPassword)
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Reset Token
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
