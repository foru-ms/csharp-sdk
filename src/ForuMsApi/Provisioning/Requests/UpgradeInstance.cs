using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record UpgradeInstance
{
    /// <summary>
    /// User provisioning key for platform-level instance management
    /// </summary>
    [JsonIgnore]
    public required string ProvisioningKey { get; set; }

    /// <summary>
    /// Instance handle
    /// </summary>
    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    /// <summary>
    /// Target plan
    /// </summary>
    [JsonPropertyName("plan")]
    public required UpgradeInstancePlan Plan { get; set; }

    /// <summary>
    /// Use annual billing (default: true)
    /// </summary>
    [JsonPropertyName("isAnnual")]
    public bool? IsAnnual { get; set; }

    /// <summary>
    /// URL to return to after checkout/portal
    /// </summary>
    [JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
