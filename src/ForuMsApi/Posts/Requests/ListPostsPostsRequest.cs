using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record ListPostsPostsRequest
{
    /// <summary>
    /// Post ID
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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
    /// Filter posts by author ID
    /// </summary>
    [JsonIgnore]
    public string? UserId { get; set; }

    /// <summary>
    /// Sort posts by creation time
    /// </summary>
    [JsonIgnore]
    public ListPostsPostsRequestSort? Sort { get; set; }

    /// <summary>
    /// Search within post body
    /// </summary>
    [JsonIgnore]
    public string? Search { get; set; }

    /// <summary>
    /// Filter by interaction type
    /// </summary>
    [JsonIgnore]
    public ListPostsPostsRequestType? Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
