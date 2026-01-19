using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsPostsRequestType>))]
[Serializable]
public readonly record struct ListPostsPostsRequestType : IStringEnum
{
    public static readonly ListPostsPostsRequestType Created = new(Values.Created);

    public static readonly ListPostsPostsRequestType Liked = new(Values.Liked);

    public static readonly ListPostsPostsRequestType Disliked = new(Values.Disliked);

    public static readonly ListPostsPostsRequestType Upvoted = new(Values.Upvoted);

    public static readonly ListPostsPostsRequestType Downvoted = new(Values.Downvoted);

    public ListPostsPostsRequestType(string value)
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
    public static ListPostsPostsRequestType FromCustom(string value)
    {
        return new ListPostsPostsRequestType(value);
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

    public static bool operator ==(ListPostsPostsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsPostsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsPostsRequestType value) => value.Value;

    public static explicit operator ListPostsPostsRequestType(string value) => new(value);

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
