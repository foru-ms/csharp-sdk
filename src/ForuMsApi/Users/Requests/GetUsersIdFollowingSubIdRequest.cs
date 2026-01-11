using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record GetUsersIdFollowingSubIdRequest
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Following ID
    /// </summary>
    [JsonIgnore]
    public required string SubId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
