using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListThreadsRequestSort>))]
[Serializable]
public readonly record struct ListThreadsRequestSort : IStringEnum
{
    public static readonly ListThreadsRequestSort Newest = new(Values.Newest);

    public static readonly ListThreadsRequestSort Oldest = new(Values.Oldest);

    public static readonly ListThreadsRequestSort Activity = new(Values.Activity);

    public ListThreadsRequestSort(string value)
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
    public static ListThreadsRequestSort FromCustom(string value)
    {
        return new ListThreadsRequestSort(value);
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

    public static bool operator ==(ListThreadsRequestSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListThreadsRequestSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListThreadsRequestSort value) => value.Value;

    public static explicit operator ListThreadsRequestSort(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Newest = "newest";

        public const string Oldest = "oldest";

        public const string Activity = "activity";
    }
}
