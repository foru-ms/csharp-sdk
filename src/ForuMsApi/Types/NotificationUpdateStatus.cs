using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<NotificationUpdateStatus>))]
[Serializable]
public readonly record struct NotificationUpdateStatus : IStringEnum
{
    public static readonly NotificationUpdateStatus Read = new(Values.Read);

    public static readonly NotificationUpdateStatus Unread = new(Values.Unread);

    public static readonly NotificationUpdateStatus Dismissed = new(Values.Dismissed);

    public static readonly NotificationUpdateStatus Archived = new(Values.Archived);

    public NotificationUpdateStatus(string value)
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
    public static NotificationUpdateStatus FromCustom(string value)
    {
        return new NotificationUpdateStatus(value);
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

    public static bool operator ==(NotificationUpdateStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotificationUpdateStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotificationUpdateStatus value) => value.Value;

    public static explicit operator NotificationUpdateStatus(string value) => new(value);

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
