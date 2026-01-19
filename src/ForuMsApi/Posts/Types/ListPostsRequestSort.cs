using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListPostsRequestSort>))]
[Serializable]
public readonly record struct ListPostsRequestSort : IStringEnum
{
    public static readonly ListPostsRequestSort Newest = new(Values.Newest);

    public static readonly ListPostsRequestSort Oldest = new(Values.Oldest);

    public ListPostsRequestSort(string value)
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
    public static ListPostsRequestSort FromCustom(string value)
    {
        return new ListPostsRequestSort(value);
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

    public static bool operator ==(ListPostsRequestSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPostsRequestSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPostsRequestSort value) => value.Value;

    public static explicit operator ListPostsRequestSort(string value) => new(value);

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
