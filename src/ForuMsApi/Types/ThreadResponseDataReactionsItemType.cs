using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ThreadResponseDataReactionsItemType>))]
[Serializable]
public readonly record struct ThreadResponseDataReactionsItemType : IStringEnum
{
    public static readonly ThreadResponseDataReactionsItemType Upvote = new(Values.Upvote);

    public static readonly ThreadResponseDataReactionsItemType Downvote = new(Values.Downvote);

    public static readonly ThreadResponseDataReactionsItemType Like = new(Values.Like);

    public static readonly ThreadResponseDataReactionsItemType Dislike = new(Values.Dislike);

    public ThreadResponseDataReactionsItemType(string value)
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
    public static ThreadResponseDataReactionsItemType FromCustom(string value)
    {
        return new ThreadResponseDataReactionsItemType(value);
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

    public static bool operator ==(ThreadResponseDataReactionsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ThreadResponseDataReactionsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ThreadResponseDataReactionsItemType value) =>
        value.Value;

    public static explicit operator ThreadResponseDataReactionsItemType(string value) => new(value);

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
