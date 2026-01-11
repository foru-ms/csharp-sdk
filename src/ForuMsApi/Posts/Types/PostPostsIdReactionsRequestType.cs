using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostPostsIdReactionsRequestType>))]
[Serializable]
public readonly record struct PostPostsIdReactionsRequestType : IStringEnum
{
    public static readonly PostPostsIdReactionsRequestType Like = new(Values.Like);

    public static readonly PostPostsIdReactionsRequestType Dislike = new(Values.Dislike);

    public static readonly PostPostsIdReactionsRequestType Upvote = new(Values.Upvote);

    public static readonly PostPostsIdReactionsRequestType Downvote = new(Values.Downvote);

    public PostPostsIdReactionsRequestType(string value)
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
    public static PostPostsIdReactionsRequestType FromCustom(string value)
    {
        return new PostPostsIdReactionsRequestType(value);
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

    public static bool operator ==(PostPostsIdReactionsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostPostsIdReactionsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostPostsIdReactionsRequestType value) => value.Value;

    public static explicit operator PostPostsIdReactionsRequestType(string value) => new(value);

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
