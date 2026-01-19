using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<IntegrationResponseDataType>))]
[Serializable]
public readonly record struct IntegrationResponseDataType : IStringEnum
{
    public static readonly IntegrationResponseDataType Slack = new(Values.Slack);

    public static readonly IntegrationResponseDataType Discord = new(Values.Discord);

    public static readonly IntegrationResponseDataType Salesforce = new(Values.Salesforce);

    public static readonly IntegrationResponseDataType Hubspot = new(Values.Hubspot);

    public static readonly IntegrationResponseDataType Okta = new(Values.Okta);

    public static readonly IntegrationResponseDataType Auth0 = new(Values.Auth0);

    public IntegrationResponseDataType(string value)
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
    public static IntegrationResponseDataType FromCustom(string value)
    {
        return new IntegrationResponseDataType(value);
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

    public static bool operator ==(IntegrationResponseDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IntegrationResponseDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IntegrationResponseDataType value) => value.Value;

    public static explicit operator IntegrationResponseDataType(string value) => new(value);

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
