using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<CreateReactionThreadsRequestType>))]
[Serializable]
public readonly record struct CreateReactionThreadsRequestType : IStringEnum
{
    public static readonly CreateReactionThreadsRequestType Like = new(Values.Like);

    public static readonly CreateReactionThreadsRequestType Dislike = new(Values.Dislike);

    public static readonly CreateReactionThreadsRequestType Upvote = new(Values.Upvote);

    public static readonly CreateReactionThreadsRequestType Downvote = new(Values.Downvote);

    public CreateReactionThreadsRequestType(string value)
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
    public static CreateReactionThreadsRequestType FromCustom(string value)
    {
        return new CreateReactionThreadsRequestType(value);
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

    public static bool operator ==(CreateReactionThreadsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateReactionThreadsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateReactionThreadsRequestType value) => value.Value;

    public static explicit operator CreateReactionThreadsRequestType(string value) => new(value);

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
