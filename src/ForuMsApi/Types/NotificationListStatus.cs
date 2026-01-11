using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<NotificationListStatus>))]
[Serializable]
public readonly record struct NotificationListStatus : IStringEnum
{
    public static readonly NotificationListStatus Read = new(Values.Read);

    public static readonly NotificationListStatus Unread = new(Values.Unread);

    public static readonly NotificationListStatus Dismissed = new(Values.Dismissed);

    public static readonly NotificationListStatus Archived = new(Values.Archived);

    public NotificationListStatus(string value)
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
    public static NotificationListStatus FromCustom(string value)
    {
        return new NotificationListStatus(value);
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

    public static bool operator ==(NotificationListStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotificationListStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotificationListStatus value) => value.Value;

    public static explicit operator NotificationListStatus(string value) => new(value);

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
