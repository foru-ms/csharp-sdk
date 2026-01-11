using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<NotificationCreateStatus>))]
[Serializable]
public readonly record struct NotificationCreateStatus : IStringEnum
{
    public static readonly NotificationCreateStatus Read = new(Values.Read);

    public static readonly NotificationCreateStatus Unread = new(Values.Unread);

    public static readonly NotificationCreateStatus Dismissed = new(Values.Dismissed);

    public static readonly NotificationCreateStatus Archived = new(Values.Archived);

    public NotificationCreateStatus(string value)
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
    public static NotificationCreateStatus FromCustom(string value)
    {
        return new NotificationCreateStatus(value);
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

    public static bool operator ==(NotificationCreateStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotificationCreateStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotificationCreateStatus value) => value.Value;

    public static explicit operator NotificationCreateStatus(string value) => new(value);

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
