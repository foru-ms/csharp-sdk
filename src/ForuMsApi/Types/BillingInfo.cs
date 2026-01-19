using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record BillingInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("instanceId")]
    public required string InstanceId { get; set; }

    [JsonPropertyName("handle")]
    public required string Handle { get; set; }

    [JsonPropertyName("plan")]
    public required BillingInfoPlan Plan { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("currentPeriodEnd")]
    public DateTime? CurrentPeriodEnd { get; set; }

    [JsonPropertyName("cancelAtPeriodEnd")]
    public required bool CancelAtPeriodEnd { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
