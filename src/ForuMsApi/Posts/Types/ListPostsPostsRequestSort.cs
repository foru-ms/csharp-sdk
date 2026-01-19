using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsPostsRequestSort>))]
[Serializable]
public readonly record struct ListPostsPostsRequestSort : IStringEnum
{
    public static readonly ListPostsPostsRequestSort Newest = new(Values.Newest);

    public static readonly ListPostsPostsRequestSort Oldest = new(Values.Oldest);

    public ListPostsPostsRequestSort(string value)
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
    public static ListPostsPostsRequestSort FromCustom(string value)
    {
        return new ListPostsPostsRequestSort(value);
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

    public static bool operator ==(ListPostsPostsRequestSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsPostsRequestSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsPostsRequestSort value) => value.Value;

    public static explicit operator ListPostsPostsRequestSort(string value) => new(value);

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
