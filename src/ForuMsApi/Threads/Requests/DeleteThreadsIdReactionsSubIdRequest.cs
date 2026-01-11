using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record DeleteThreadsIdReactionsSubIdRequest
{
    /// <summary>
    /// Thread ID
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Reaction ID
    /// </summary>
    [JsonIgnore]
    public required string SubId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
