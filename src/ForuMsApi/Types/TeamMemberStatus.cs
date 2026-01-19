using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<TeamMemberStatus>))]
[Serializable]
public readonly record struct TeamMemberStatus : IStringEnum
{
    public static readonly TeamMemberStatus Pending = new(Values.Pending);

    public static readonly TeamMemberStatus Accepted = new(Values.Accepted);

    public static readonly TeamMemberStatus Declined = new(Values.Declined);

    public TeamMemberStatus(string value)
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
    public static TeamMemberStatus FromCustom(string value)
    {
        return new TeamMemberStatus(value);
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

    public static bool operator ==(TeamMemberStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TeamMemberStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TeamMemberStatus value) => value.Value;

    public static explicit operator TeamMemberStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string Accepted = "ACCEPTED";

        public const string Declined = "DECLINED";
    }
}
