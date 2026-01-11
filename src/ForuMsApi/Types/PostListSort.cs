using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostListSort>))]
[Serializable]
public readonly record struct PostListSort : IStringEnum
{
    public static readonly PostListSort Newest = new(Values.Newest);

    public static readonly PostListSort Oldest = new(Values.Oldest);

    public PostListSort(string value)
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
    public static PostListSort FromCustom(string value)
    {
        return new PostListSort(value);
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

    public static bool operator ==(PostListSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostListSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostListSort value) => value.Value;

    public static explicit operator PostListSort(string value) => new(value);

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
