using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record NotificationList : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Items per page (max 75)
    /// </summary>
    [JsonPropertyName("limit")]
    public double? Limit { get; set; }

    /// <summary>
    /// Cursor for pagination
    /// </summary>
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }

    /// <summary>
    /// Filter by notification status
    /// </summary>
    [JsonPropertyName("status")]
    public NotificationListStatus? Status { get; set; }

    /// <summary>
    /// Filter by recipient user ID (admin only)
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

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
