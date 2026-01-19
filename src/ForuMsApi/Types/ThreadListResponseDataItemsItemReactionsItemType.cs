using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ThreadListResponseDataItemsItemReactionsItemType>))]
[Serializable]
public readonly record struct ThreadListResponseDataItemsItemReactionsItemType : IStringEnum
{
    public static readonly ThreadListResponseDataItemsItemReactionsItemType Upvote = new(
        Values.Upvote
    );

    public static readonly ThreadListResponseDataItemsItemReactionsItemType Downvote = new(
        Values.Downvote
    );

    public static readonly ThreadListResponseDataItemsItemReactionsItemType Like = new(Values.Like);

    public static readonly ThreadListResponseDataItemsItemReactionsItemType Dislike = new(
        Values.Dislike
    );

    public ThreadListResponseDataItemsItemReactionsItemType(string value)
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
    public static ThreadListResponseDataItemsItemReactionsItemType FromCustom(string value)
    {
        return new ThreadListResponseDataItemsItemReactionsItemType(value);
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

    public static bool operator ==(
        ThreadListResponseDataItemsItemReactionsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ThreadListResponseDataItemsItemReactionsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ThreadListResponseDataItemsItemReactionsItemType value
    ) => value.Value;

    public static explicit operator ThreadListResponseDataItemsItemReactionsItemType(
        string value
    ) => new(value);

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
