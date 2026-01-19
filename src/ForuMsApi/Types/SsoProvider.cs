using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<SsoProvider>))]
[Serializable]
public readonly record struct SsoProvider : IStringEnum
{
    public static readonly SsoProvider Okta = new(Values.Okta);

    public static readonly SsoProvider Auth0 = new(Values.Auth0);

    public static readonly SsoProvider Saml = new(Values.Saml);

    public SsoProvider(string value)
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
    public static SsoProvider FromCustom(string value)
    {
        return new SsoProvider(value);
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

    public static bool operator ==(SsoProvider value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SsoProvider value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SsoProvider value) => value.Value;

    public static explicit operator SsoProvider(string value) => new(value);

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
