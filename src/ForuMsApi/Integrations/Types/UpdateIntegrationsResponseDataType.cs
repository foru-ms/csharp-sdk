using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UpdateIntegrationsResponseDataType>))]
[Serializable]
public readonly record struct UpdateIntegrationsResponseDataType : IStringEnum
{
    public static readonly UpdateIntegrationsResponseDataType Slack = new(Values.Slack);

    public static readonly UpdateIntegrationsResponseDataType Discord = new(Values.Discord);

    public static readonly UpdateIntegrationsResponseDataType Salesforce = new(Values.Salesforce);

    public static readonly UpdateIntegrationsResponseDataType Hubspot = new(Values.Hubspot);

    public static readonly UpdateIntegrationsResponseDataType Okta = new(Values.Okta);

    public static readonly UpdateIntegrationsResponseDataType Auth0 = new(Values.Auth0);

    public UpdateIntegrationsResponseDataType(string value)
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
    public static UpdateIntegrationsResponseDataType FromCustom(string value)
    {
        return new UpdateIntegrationsResponseDataType(value);
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

    public static bool operator ==(UpdateIntegrationsResponseDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateIntegrationsResponseDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateIntegrationsResponseDataType value) => value.Value;

    public static explicit operator UpdateIntegrationsResponseDataType(string value) => new(value);

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
