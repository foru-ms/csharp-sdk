using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record DeleteUsersIdFollowersSubIdRequest
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Follower ID
    /// </summary>
    [JsonIgnore]
    public required string SubId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
