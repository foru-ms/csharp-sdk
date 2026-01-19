using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UpdateSsOsRequestProvider>))]
[Serializable]
public readonly record struct UpdateSsOsRequestProvider : IStringEnum
{
    public static readonly UpdateSsOsRequestProvider Okta = new(Values.Okta);

    public static readonly UpdateSsOsRequestProvider Auth0 = new(Values.Auth0);

    public static readonly UpdateSsOsRequestProvider Saml = new(Values.Saml);

    public UpdateSsOsRequestProvider(string value)
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
    public static UpdateSsOsRequestProvider FromCustom(string value)
    {
        return new UpdateSsOsRequestProvider(value);
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

    public static bool operator ==(UpdateSsOsRequestProvider value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateSsOsRequestProvider value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateSsOsRequestProvider value) => value.Value;

    public static explicit operator UpdateSsOsRequestProvider(string value) => new(value);

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
