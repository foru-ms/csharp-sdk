using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostListType>))]
[Serializable]
public readonly record struct PostListType : IStringEnum
{
    public static readonly PostListType Created = new(Values.Created);

    public static readonly PostListType Liked = new(Values.Liked);

    public static readonly PostListType Disliked = new(Values.Disliked);

    public static readonly PostListType Upvoted = new(Values.Upvoted);

    public static readonly PostListType Downvoted = new(Values.Downvoted);

    public PostListType(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PostListType FromCustom(string value)
    {
        return new PostListType(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(PostListType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostListType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostListType value) => value.Value;

    public static explicit operator PostListType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Created = "created";

        public const string Liked = "liked";

        public const string Disliked = "disliked";

        public const string Upvoted = "upvoted";

        public const string Downvoted = "downvoted";
    }
}
