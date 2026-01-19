using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UpdateThreadsResponseDataReactionsItemType>))]
[Serializable]
public readonly record struct UpdateThreadsResponseDataReactionsItemType : IStringEnum
{
    public static readonly UpdateThreadsResponseDataReactionsItemType Upvote = new(Values.Upvote);

    public static readonly UpdateThreadsResponseDataReactionsItemType Downvote = new(
        Values.Downvote
    );

    public static readonly UpdateThreadsResponseDataReactionsItemType Like = new(Values.Like);

    public static readonly UpdateThreadsResponseDataReactionsItemType Dislike = new(Values.Dislike);

    public UpdateThreadsResponseDataReactionsItemType(string value)
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
    public static UpdateThreadsResponseDataReactionsItemType FromCustom(string value)
    {
        return new UpdateThreadsResponseDataReactionsItemType(value);
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
        UpdateThreadsResponseDataReactionsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateThreadsResponseDataReactionsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateThreadsResponseDataReactionsItemType value) =>
        value.Value;

    public static explicit operator UpdateThreadsResponseDataReactionsItemType(string value) =>
        new(value);

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
