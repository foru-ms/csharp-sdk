using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<BillingInfoPlan>))]
[Serializable]
public readonly record struct BillingInfoPlan : IStringEnum
{
    public static readonly BillingInfoPlan Free = new(Values.Free);

    public static readonly BillingInfoPlan Starter = new(Values.Starter);

    public static readonly BillingInfoPlan Pro = new(Values.Pro);

    public static readonly BillingInfoPlan Enterprise = new(Values.Enterprise);

    public BillingInfoPlan(string value)
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
    public static BillingInfoPlan FromCustom(string value)
    {
        return new BillingInfoPlan(value);
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

    public static bool operator ==(BillingInfoPlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BillingInfoPlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BillingInfoPlan value) => value.Value;

    public static explicit operator BillingInfoPlan(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Free = "FREE";

        public const string Starter = "STARTER";

        public const string Pro = "PRO";

        public const string Enterprise = "ENTERPRISE";
    }
}
