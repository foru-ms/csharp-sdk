using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<RoleListSort>))]
[Serializable]
public readonly record struct RoleListSort : IStringEnum
{
    public static readonly RoleListSort Newest = new(Values.Newest);

    public static readonly RoleListSort Oldest = new(Values.Oldest);

    public static readonly RoleListSort Name = new(Values.Name);

    public RoleListSort(string value)
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
    public static RoleListSort FromCustom(string value)
    {
        return new RoleListSort(value);
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

    public static bool operator ==(RoleListSort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RoleListSort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RoleListSort value) => value.Value;

    public static explicit operator RoleListSort(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Newest = "newest";

        public const string Oldest = "oldest";

        public const string Name = "name";
    }
}
