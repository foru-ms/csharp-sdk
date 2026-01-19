using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record CreateNotificationsRequest
{
    /// <summary>
    /// Target user ID to receive notification (maps to userId)
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// User ID who triggered the notification (optional, defaults to authenticated user)
    /// </summary>
    [JsonPropertyName("notifierId")]
    public string? NotifierId { get; set; }

    /// <summary>
    /// Notification type (e.g. mention, reply, follow)
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Notification text content
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Related thread ID
    /// </summary>
    [JsonPropertyName("threadId")]
    public string? ThreadId { get; set; }

    /// <summary>
    /// Related post ID
    /// </summary>
    [JsonPropertyName("postId")]
    public string? PostId { get; set; }

    /// <summary>
    /// Related private message ID
    /// </summary>
    [JsonPropertyName("privateMessageId")]
    public string? PrivateMessageId { get; set; }

    /// <summary>
    /// Initial notification status
    /// </summary>
    [JsonPropertyName("status")]
    public CreateNotificationsRequestStatus? Status { get; set; }

    /// <summary>
    /// Additional notification data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
