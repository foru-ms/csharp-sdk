using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<InviteTeamProvisioningRequestMembersItemRole>))]
[Serializable]
public readonly record struct InviteTeamProvisioningRequestMembersItemRole : IStringEnum
{
    public static readonly InviteTeamProvisioningRequestMembersItemRole Member = new(Values.Member);

    public static readonly InviteTeamProvisioningRequestMembersItemRole Owner = new(Values.Owner);

    public InviteTeamProvisioningRequestMembersItemRole(string value)
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
    public static InviteTeamProvisioningRequestMembersItemRole FromCustom(string value)
    {
        return new InviteTeamProvisioningRequestMembersItemRole(value);
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

    public static bool operator ==(
        InviteTeamProvisioningRequestMembersItemRole value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InviteTeamProvisioningRequestMembersItemRole value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InviteTeamProvisioningRequestMembersItemRole value) =>
        value.Value;

    public static explicit operator InviteTeamProvisioningRequestMembersItemRole(string value) =>
        new(value);

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
