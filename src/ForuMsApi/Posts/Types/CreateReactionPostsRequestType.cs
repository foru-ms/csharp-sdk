using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<CreateReactionPostsRequestType>))]
[Serializable]
public readonly record struct CreateReactionPostsRequestType : IStringEnum
{
    public static readonly CreateReactionPostsRequestType Like = new(Values.Like);

    public static readonly CreateReactionPostsRequestType Dislike = new(Values.Dislike);

    public static readonly CreateReactionPostsRequestType Upvote = new(Values.Upvote);

    public static readonly CreateReactionPostsRequestType Downvote = new(Values.Downvote);

    public CreateReactionPostsRequestType(string value)
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
    public static CreateReactionPostsRequestType FromCustom(string value)
    {
        return new CreateReactionPostsRequestType(value);
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

    public static bool operator ==(CreateReactionPostsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateReactionPostsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateReactionPostsRequestType value) => value.Value;

    public static explicit operator CreateReactionPostsRequestType(string value) => new(value);

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
