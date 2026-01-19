using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListReactionsThreadsRequestType>))]
[Serializable]
public readonly record struct ListReactionsThreadsRequestType : IStringEnum
{
    public static readonly ListReactionsThreadsRequestType Like = new(Values.Like);

    public static readonly ListReactionsThreadsRequestType Dislike = new(Values.Dislike);

    public static readonly ListReactionsThreadsRequestType Upvote = new(Values.Upvote);

    public static readonly ListReactionsThreadsRequestType Downvote = new(Values.Downvote);

    public ListReactionsThreadsRequestType(string value)
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
    public static ListReactionsThreadsRequestType FromCustom(string value)
    {
        return new ListReactionsThreadsRequestType(value);
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

    public static bool operator ==(ListReactionsThreadsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListReactionsThreadsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListReactionsThreadsRequestType value) => value.Value;

    public static explicit operator ListReactionsThreadsRequestType(string value) => new(value);

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
