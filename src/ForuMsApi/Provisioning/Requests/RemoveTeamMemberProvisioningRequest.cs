using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record RemoveTeamMemberProvisioningRequest
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
