using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PatchNotificationsIdRequestStatus>))]
[Serializable]
public readonly record struct PatchNotificationsIdRequestStatus : IStringEnum
{
    public static readonly PatchNotificationsIdRequestStatus Read = new(Values.Read);

    public static readonly PatchNotificationsIdRequestStatus Unread = new(Values.Unread);

    public static readonly PatchNotificationsIdRequestStatus Dismissed = new(Values.Dismissed);

    public static readonly PatchNotificationsIdRequestStatus Archived = new(Values.Archived);

    public PatchNotificationsIdRequestStatus(string value)
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
    public static PatchNotificationsIdRequestStatus FromCustom(string value)
    {
        return new PatchNotificationsIdRequestStatus(value);
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

    public static bool operator ==(PatchNotificationsIdRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatchNotificationsIdRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatchNotificationsIdRequestStatus value) => value.Value;

    public static explicit operator PatchNotificationsIdRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Read = "read";

        public const string Unread = "unread";

        public const string Dismissed = "dismissed";

        public const string Archived = "archived";
    }
}
