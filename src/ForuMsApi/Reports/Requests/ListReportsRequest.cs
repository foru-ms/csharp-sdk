using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record ListReportsRequest
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
    /// Filter by status
    /// </summary>
    [JsonIgnore]
    public string? Status { get; set; }

    /// <summary>
    /// Filter by reporter ID
    /// </summary>
    [JsonIgnore]
    public string? ReporterId { get; set; }

    /// <summary>
    /// Filter by reported user ID
    /// </summary>
    [JsonIgnore]
    public string? ReportedId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
