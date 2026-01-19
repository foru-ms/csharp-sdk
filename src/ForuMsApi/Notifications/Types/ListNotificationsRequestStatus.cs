using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<ListNotificationsRequestStatus>))]
[Serializable]
public readonly record struct ListNotificationsRequestStatus : IStringEnum
{
    public static readonly ListNotificationsRequestStatus Read = new(Values.Read);

    public static readonly ListNotificationsRequestStatus Unread = new(Values.Unread);

    public static readonly ListNotificationsRequestStatus Dismissed = new(Values.Dismissed);

    public static readonly ListNotificationsRequestStatus Archived = new(Values.Archived);

    public ListNotificationsRequestStatus(string value)
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
    public static ListNotificationsRequestStatus FromCustom(string value)
    {
        return new ListNotificationsRequestStatus(value);
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

    public static bool operator ==(ListNotificationsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListNotificationsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListNotificationsRequestStatus value) => value.Value;

    public static explicit operator ListNotificationsRequestStatus(string value) => new(value);

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
