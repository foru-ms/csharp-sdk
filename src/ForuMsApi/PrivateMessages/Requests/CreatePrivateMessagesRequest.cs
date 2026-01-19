using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record CreatePrivateMessagesRequest
{
    /// <summary>
    /// Recipient User ID
    /// </summary>
    [JsonPropertyName("recipientId")]
    public required string RecipientId { get; set; }

    /// <summary>
    /// Sender user ID (required for API key auth, ignored for JWT auth)
    /// </summary>
    [JsonPropertyName("senderId")]
    public string? SenderId { get; set; }

    /// <summary>
    /// Message title (optional for replies)
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Message content
    /// </summary>
    [JsonPropertyName("body")]
    public required string Body { get; set; }

    /// <summary>
    /// Parent Message ID (for replies)
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// Extended data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
