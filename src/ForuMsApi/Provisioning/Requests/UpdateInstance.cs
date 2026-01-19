using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record UpdateInstance
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    /// <summary>
    /// Current handle to identify the instance
    /// </summary>
    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    /// <summary>
    /// New display name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// New URL-friendly identifier
    /// </summary>
    [JsonPropertyName("newHandle")]
    public string? NewHandle { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
