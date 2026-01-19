using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<TeamMemberRole>))]
[Serializable]
public readonly record struct TeamMemberRole : IStringEnum
{
    public static readonly TeamMemberRole Member = new(Values.Member);

    public static readonly TeamMemberRole Owner = new(Values.Owner);

    public TeamMemberRole(string value)
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
    public static TeamMemberRole FromCustom(string value)
    {
        return new TeamMemberRole(value);
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

    public static bool operator ==(TeamMemberRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TeamMemberRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TeamMemberRole value) => value.Value;

    public static explicit operator TeamMemberRole(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Member = "MEMBER";

        public const string Owner = "OWNER";
    }
}
