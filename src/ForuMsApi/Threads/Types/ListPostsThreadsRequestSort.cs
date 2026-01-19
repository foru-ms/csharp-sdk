using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsThreadsRequestSort>))]
[Serializable]
public readonly record struct ListPostsThreadsRequestSort : IStringEnum
{
    public static readonly ListPostsThreadsRequestSort Newest = new(Values.Newest);

    public static readonly ListPostsThreadsRequestSort Oldest = new(Values.Oldest);

    public ListPostsThreadsRequestSort(string value)
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
    public static ListPostsThreadsRequestSort FromCustom(string value)
    {
        return new ListPostsThreadsRequestSort(value);
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

    public static bool operator ==(ListPostsThreadsRequestSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsThreadsRequestSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsThreadsRequestSort value) => value.Value;

    public static explicit operator ListPostsThreadsRequestSort(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Newest = "newest";

        public const string Oldest = "oldest";
    }
}
