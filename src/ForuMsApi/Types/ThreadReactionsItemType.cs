using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ThreadReactionsItemType>))]
[Serializable]
public readonly record struct ThreadReactionsItemType : IStringEnum
{
    public static readonly ThreadReactionsItemType Upvote = new(Values.Upvote);

    public static readonly ThreadReactionsItemType Downvote = new(Values.Downvote);

    public static readonly ThreadReactionsItemType Like = new(Values.Like);

    public static readonly ThreadReactionsItemType Dislike = new(Values.Dislike);

    public ThreadReactionsItemType(string value)
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
    public static ThreadReactionsItemType FromCustom(string value)
    {
        return new ThreadReactionsItemType(value);
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

    public static bool operator ==(ThreadReactionsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ThreadReactionsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ThreadReactionsItemType value) => value.Value;

    public static explicit operator ThreadReactionsItemType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Upvote = "UPVOTE";

        public const string Downvote = "DOWNVOTE";

        public const string Like = "LIKE";

        public const string Dislike = "DISLIKE";
    }
}
