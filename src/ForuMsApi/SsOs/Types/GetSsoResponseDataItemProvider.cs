using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<GetSsoResponseDataItemProvider>))]
[Serializable]
public readonly record struct GetSsoResponseDataItemProvider : IStringEnum
{
    public static readonly GetSsoResponseDataItemProvider Okta = new(Values.Okta);

    public static readonly GetSsoResponseDataItemProvider Auth0 = new(Values.Auth0);

    public static readonly GetSsoResponseDataItemProvider Saml = new(Values.Saml);

    public GetSsoResponseDataItemProvider(string value)
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
    public static GetSsoResponseDataItemProvider FromCustom(string value)
    {
        return new GetSsoResponseDataItemProvider(value);
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

    public static bool operator ==(GetSsoResponseDataItemProvider value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetSsoResponseDataItemProvider value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetSsoResponseDataItemProvider value) => value.Value;

    public static explicit operator GetSsoResponseDataItemProvider(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Okta = "OKTA";

        public const string Auth0 = "AUTH0";

        public const string Saml = "SAML";
    }
}
