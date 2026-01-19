using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListReactionsPostsRequestType>))]
[Serializable]
public readonly record struct ListReactionsPostsRequestType : IStringEnum
{
    public static readonly ListReactionsPostsRequestType Like = new(Values.Like);

    public static readonly ListReactionsPostsRequestType Dislike = new(Values.Dislike);

    public static readonly ListReactionsPostsRequestType Upvote = new(Values.Upvote);

    public static readonly ListReactionsPostsRequestType Downvote = new(Values.Downvote);

    public ListReactionsPostsRequestType(string value)
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
    public static ListReactionsPostsRequestType FromCustom(string value)
    {
        return new ListReactionsPostsRequestType(value);
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

    public static bool operator ==(ListReactionsPostsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListReactionsPostsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListReactionsPostsRequestType value) => value.Value;

    public static explicit operator ListReactionsPostsRequestType(string value) => new(value);

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
