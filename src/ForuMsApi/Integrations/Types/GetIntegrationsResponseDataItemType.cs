using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<GetIntegrationsResponseDataItemType>))]
[Serializable]
public readonly record struct GetIntegrationsResponseDataItemType : IStringEnum
{
    public static readonly GetIntegrationsResponseDataItemType Slack = new(Values.Slack);

    public static readonly GetIntegrationsResponseDataItemType Discord = new(Values.Discord);

    public static readonly GetIntegrationsResponseDataItemType Salesforce = new(Values.Salesforce);

    public static readonly GetIntegrationsResponseDataItemType Hubspot = new(Values.Hubspot);

    public static readonly GetIntegrationsResponseDataItemType Okta = new(Values.Okta);

    public static readonly GetIntegrationsResponseDataItemType Auth0 = new(Values.Auth0);

    public GetIntegrationsResponseDataItemType(string value)
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
    public static GetIntegrationsResponseDataItemType FromCustom(string value)
    {
        return new GetIntegrationsResponseDataItemType(value);
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

    public static bool operator ==(GetIntegrationsResponseDataItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetIntegrationsResponseDataItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetIntegrationsResponseDataItemType value) =>
        value.Value;

    public static explicit operator GetIntegrationsResponseDataItemType(string value) => new(value);

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
