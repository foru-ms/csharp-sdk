using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostReactionCreateType>))]
[Serializable]
public readonly record struct PostReactionCreateType : IStringEnum
{
    public static readonly PostReactionCreateType Like = new(Values.Like);

    public static readonly PostReactionCreateType Dislike = new(Values.Dislike);

    public static readonly PostReactionCreateType Upvote = new(Values.Upvote);

    public static readonly PostReactionCreateType Downvote = new(Values.Downvote);

    public PostReactionCreateType(string value)
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
    public static PostReactionCreateType FromCustom(string value)
    {
        return new PostReactionCreateType(value);
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

    public static bool operator ==(PostReactionCreateType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostReactionCreateType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostReactionCreateType value) => value.Value;

    public static explicit operator PostReactionCreateType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Like = "LIKE";

        public const string Dislike = "DISLIKE";

        public const string Upvote = "UPVOTE";

        public const string Downvote = "DOWNVOTE";
    }
}
