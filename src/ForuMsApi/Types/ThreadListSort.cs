using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ThreadListSort>))]
[Serializable]
public readonly record struct ThreadListSort : IStringEnum
{
    public static readonly ThreadListSort Newest = new(Values.Newest);

    public static readonly ThreadListSort Oldest = new(Values.Oldest);

    public static readonly ThreadListSort Activity = new(Values.Activity);

    public ThreadListSort(string value)
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
    public static ThreadListSort FromCustom(string value)
    {
        return new ThreadListSort(value);
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

    public static bool operator ==(ThreadListSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ThreadListSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ThreadListSort value) => value.Value;

    public static explicit operator ThreadListSort(string value) => new(value);

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
