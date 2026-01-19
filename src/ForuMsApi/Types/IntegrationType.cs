using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<IntegrationType>))]
[Serializable]
public readonly record struct IntegrationType : IStringEnum
{
    public static readonly IntegrationType Slack = new(Values.Slack);

    public static readonly IntegrationType Discord = new(Values.Discord);

    public static readonly IntegrationType Salesforce = new(Values.Salesforce);

    public static readonly IntegrationType Hubspot = new(Values.Hubspot);

    public static readonly IntegrationType Okta = new(Values.Okta);

    public static readonly IntegrationType Auth0 = new(Values.Auth0);

    public IntegrationType(string value)
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
    public static IntegrationType FromCustom(string value)
    {
        return new IntegrationType(value);
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

    public static bool operator ==(IntegrationType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IntegrationType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IntegrationType value) => value.Value;

    public static explicit operator IntegrationType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Slack = "SLACK";

        public const string Discord = "DISCORD";

        public const string Salesforce = "SALESFORCE";

        public const string Hubspot = "HUBSPOT";

        public const string Okta = "OKTA";

        public const string Auth0 = "AUTH0";
    }
}
