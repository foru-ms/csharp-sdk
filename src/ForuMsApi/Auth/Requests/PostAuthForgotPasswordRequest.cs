using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostAuthForgotPasswordRequest
{
    /// <summary>
    /// User Email
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
