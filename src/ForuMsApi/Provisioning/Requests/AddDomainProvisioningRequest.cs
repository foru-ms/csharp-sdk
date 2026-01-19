using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record AddDomainProvisioningRequest
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    /// <summary>
    /// Domain name (e.g., forum.example.com)
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
