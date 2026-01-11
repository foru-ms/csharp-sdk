using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PatchNotificationsIdRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Notification status
    /// </summary>
    [JsonPropertyName("status")]
    public PatchNotificationsIdRequestStatus? Status { get; set; }

    /// <summary>
    /// Update extended data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
