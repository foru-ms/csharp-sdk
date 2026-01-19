using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record InviteTeamProvisioningRequest
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    [JsonPropertyName("members")]
    public IEnumerable<InviteTeamProvisioningRequestMembersItem> Members { get; set; } =
        new List<InviteTeamProvisioningRequestMembersItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
