using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record ListNotificationsRequest
{
    /// <summary>
    /// Items per page (max 75)
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Cursor for pagination
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Filter by notification status
    /// </summary>
    [JsonIgnore]
    public ListNotificationsRequestStatus? Status { get; set; }

    /// <summary>
    /// Filter by recipient user ID (admin only)
    /// </summary>
    [JsonIgnore]
    public string? UserId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
