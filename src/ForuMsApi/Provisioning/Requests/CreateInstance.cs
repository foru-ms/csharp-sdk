using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record CreateInstance
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    /// <summary>
    /// Display name for the instance
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// URL-friendly identifier (slug)
    /// </summary>
    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
