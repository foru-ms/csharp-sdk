using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<SsoUpdateProvider>))]
[Serializable]
public readonly record struct SsoUpdateProvider : IStringEnum
{
    public static readonly SsoUpdateProvider Okta = new(Values.Okta);

    public static readonly SsoUpdateProvider Auth0 = new(Values.Auth0);

    public static readonly SsoUpdateProvider Saml = new(Values.Saml);

    public SsoUpdateProvider(string value)
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
    public static SsoUpdateProvider FromCustom(string value)
    {
        return new SsoUpdateProvider(value);
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

    public static bool operator ==(SsoUpdateProvider value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SsoUpdateProvider value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SsoUpdateProvider value) => value.Value;

    public static explicit operator SsoUpdateProvider(string value) => new(value);

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
