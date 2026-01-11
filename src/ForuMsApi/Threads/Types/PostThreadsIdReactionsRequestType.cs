using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostThreadsIdReactionsRequestType>))]
[Serializable]
public readonly record struct PostThreadsIdReactionsRequestType : IStringEnum
{
    public static readonly PostThreadsIdReactionsRequestType Like = new(Values.Like);

    public static readonly PostThreadsIdReactionsRequestType Dislike = new(Values.Dislike);

    public static readonly PostThreadsIdReactionsRequestType Upvote = new(Values.Upvote);

    public static readonly PostThreadsIdReactionsRequestType Downvote = new(Values.Downvote);

    public PostThreadsIdReactionsRequestType(string value)
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
    public static PostThreadsIdReactionsRequestType FromCustom(string value)
    {
        return new PostThreadsIdReactionsRequestType(value);
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

    public static bool operator ==(PostThreadsIdReactionsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostThreadsIdReactionsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostThreadsIdReactionsRequestType value) => value.Value;

    public static explicit operator PostThreadsIdReactionsRequestType(string value) => new(value);

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
