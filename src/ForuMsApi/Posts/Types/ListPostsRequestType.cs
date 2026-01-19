using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsRequestType>))]
[Serializable]
public readonly record struct ListPostsRequestType : IStringEnum
{
    public static readonly ListPostsRequestType Created = new(Values.Created);

    public static readonly ListPostsRequestType Liked = new(Values.Liked);

    public static readonly ListPostsRequestType Disliked = new(Values.Disliked);

    public static readonly ListPostsRequestType Upvoted = new(Values.Upvoted);

    public static readonly ListPostsRequestType Downvoted = new(Values.Downvoted);

    public ListPostsRequestType(string value)
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
    public static ListPostsRequestType FromCustom(string value)
    {
        return new ListPostsRequestType(value);
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

    public static bool operator ==(ListPostsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsRequestType value) => value.Value;

    public static explicit operator ListPostsRequestType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Created = "created";

        public const string Liked = "liked";

        public const string Disliked = "disliked";

        public const string Upvoted = "upvoted";

        public const string Downvoted = "downvoted";
    }
}
