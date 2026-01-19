using System.Text.Json;
using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[Serializable]
public record UserResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("username")]
    public required string Username { get; set; }

    /// <summary>
    /// Email address
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Display name
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// User bio
    /// </summary>
    [JsonPropertyName("bio")]
    public string? Bio { get; set; }

    /// <summary>
    /// Forum signature
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// User website URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Total posts by user
    /// </summary>
    [JsonPropertyName("postsCount")]
    public int? PostsCount { get; set; }

    /// <summary>
    /// Total threads by user
    /// </summary>
    [JsonPropertyName("threadsCount")]
    public int? ThreadsCount { get; set; }

    /// <summary>
    /// Online status
    /// </summary>
    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>
    /// Last activity timestamp
    /// </summary>
    [JsonPropertyName("lastSeenAt")]
    public string? LastSeenAt { get; set; }

    /// <summary>
    /// User roles
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<UserResponseDataRolesItem>? Roles { get; set; }

    /// <summary>
    /// Custom user data
    /// </summary>
    [JsonPropertyName("extendedData")]
    public Dictionary<string, object?>? ExtendedData { get; set; }

    /// <summary>
    /// Account creation timestamp
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    /// <summary>
    /// Profile last update timestamp
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
