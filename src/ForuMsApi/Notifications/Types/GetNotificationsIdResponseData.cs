using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record GetNotificationsIdResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Recipient user ID
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// User ID who triggered the notification
    /// </summary>
    [JsonPropertyName("notifierId")]
    public required string NotifierId { get; set; }

    /// <summary>
    /// Notification type
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Notification text content
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Notification status (read, unread, dismissed, archived)
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

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
    /// Additional notification data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <summary>
    /// Notification creation timestamp
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    /// <summary>
    /// Notification last update timestamp
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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
