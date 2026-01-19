using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ChangePlanProvisioningResponseDataAction>))]
[Serializable]
public readonly record struct ChangePlanProvisioningResponseDataAction : IStringEnum
{
    public static readonly ChangePlanProvisioningResponseDataAction Checkout = new(Values.Checkout);

    public static readonly ChangePlanProvisioningResponseDataAction Portal = new(Values.Portal);

    public ChangePlanProvisioningResponseDataAction(string value)
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
    public static ChangePlanProvisioningResponseDataAction FromCustom(string value)
    {
        return new ChangePlanProvisioningResponseDataAction(value);
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
        ChangePlanProvisioningResponseDataAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangePlanProvisioningResponseDataAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangePlanProvisioningResponseDataAction value) =>
        value.Value;

    public static explicit operator ChangePlanProvisioningResponseDataAction(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Checkout = "checkout";

        public const string Portal = "portal";
    }
}
