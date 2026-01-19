using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UpgradeInstancePlan>))]
[Serializable]
public readonly record struct UpgradeInstancePlan : IStringEnum
{
    public static readonly UpgradeInstancePlan Free = new(Values.Free);

    public static readonly UpgradeInstancePlan Starter = new(Values.Starter);

    public static readonly UpgradeInstancePlan Pro = new(Values.Pro);

    public UpgradeInstancePlan(string value)
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
    public static UpgradeInstancePlan FromCustom(string value)
    {
        return new UpgradeInstancePlan(value);
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

    public static bool operator ==(UpgradeInstancePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpgradeInstancePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpgradeInstancePlan value) => value.Value;

    public static explicit operator UpgradeInstancePlan(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Free = "FREE";

        public const string Starter = "STARTER";

        public const string Pro = "PRO";
    }
}
