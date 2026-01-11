using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record PostReportsRequest
{
    /// <summary>
    /// Report type (e.g. spam, abuse)
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Reason for reporting
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Reporter user ID (required for API key auth, ignored for JWT auth)
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// ID of user being reported
    /// </summary>
    [JsonPropertyName("reportedId")]
    public string? ReportedId { get; set; }

    /// <summary>
    /// ID of thread being reported
    /// </summary>
    [JsonPropertyName("threadId")]
    public string? ThreadId { get; set; }

    /// <summary>
    /// ID of post being reported
    /// </summary>
    [JsonPropertyName("postId")]
    public string? PostId { get; set; }

    /// <summary>
    /// ID of private message being reported
    /// </summary>
    [JsonPropertyName("privateMessageId")]
    public string? PrivateMessageId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
