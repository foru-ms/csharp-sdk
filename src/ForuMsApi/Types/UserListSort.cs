using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UserListSort>))]
[Serializable]
public readonly record struct UserListSort : IStringEnum
{
    public static readonly UserListSort Newest = new(Values.Newest);

    public static readonly UserListSort Oldest = new(Values.Oldest);

    public UserListSort(string value)
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
    public static UserListSort FromCustom(string value)
    {
        return new UserListSort(value);
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

    public static bool operator ==(UserListSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UserListSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UserListSort value) => value.Value;

    public static explicit operator UserListSort(string value) => new(value);

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
