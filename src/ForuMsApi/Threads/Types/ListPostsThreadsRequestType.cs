using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsThreadsRequestType>))]
[Serializable]
public readonly record struct ListPostsThreadsRequestType : IStringEnum
{
    public static readonly ListPostsThreadsRequestType Created = new(Values.Created);

    public static readonly ListPostsThreadsRequestType Liked = new(Values.Liked);

    public static readonly ListPostsThreadsRequestType Disliked = new(Values.Disliked);

    public static readonly ListPostsThreadsRequestType Upvoted = new(Values.Upvoted);

    public static readonly ListPostsThreadsRequestType Downvoted = new(Values.Downvoted);

    public ListPostsThreadsRequestType(string value)
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
    public static ListPostsThreadsRequestType FromCustom(string value)
    {
        return new ListPostsThreadsRequestType(value);
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

    public static bool operator ==(ListPostsThreadsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsThreadsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsThreadsRequestType value) => value.Value;

    public static explicit operator ListPostsThreadsRequestType(string value) => new(value);

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
