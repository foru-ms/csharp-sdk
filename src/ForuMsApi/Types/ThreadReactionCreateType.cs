using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ThreadReactionCreateType>))]
[Serializable]
public readonly record struct ThreadReactionCreateType : IStringEnum
{
    public static readonly ThreadReactionCreateType Like = new(Values.Like);

    public static readonly ThreadReactionCreateType Dislike = new(Values.Dislike);

    public static readonly ThreadReactionCreateType Upvote = new(Values.Upvote);

    public static readonly ThreadReactionCreateType Downvote = new(Values.Downvote);

    public ThreadReactionCreateType(string value)
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
    public static ThreadReactionCreateType FromCustom(string value)
    {
        return new ThreadReactionCreateType(value);
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

    public static bool operator ==(ThreadReactionCreateType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ThreadReactionCreateType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ThreadReactionCreateType value) => value.Value;

    public static explicit operator ThreadReactionCreateType(string value) => new(value);

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
