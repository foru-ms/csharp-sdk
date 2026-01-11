using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<IntegrationResponseType>))]
[Serializable]
public readonly record struct IntegrationResponseType : IStringEnum
{
    public static readonly IntegrationResponseType Slack = new(Values.Slack);

    public static readonly IntegrationResponseType Discord = new(Values.Discord);

    public static readonly IntegrationResponseType Salesforce = new(Values.Salesforce);

    public static readonly IntegrationResponseType Hubspot = new(Values.Hubspot);

    public static readonly IntegrationResponseType Okta = new(Values.Okta);

    public static readonly IntegrationResponseType Auth0 = new(Values.Auth0);

    public IntegrationResponseType(string value)
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
    public static IntegrationResponseType FromCustom(string value)
    {
        return new IntegrationResponseType(value);
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

    public static bool operator ==(IntegrationResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IntegrationResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IntegrationResponseType value) => value.Value;

    public static explicit operator IntegrationResponseType(string value) => new(value);

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
