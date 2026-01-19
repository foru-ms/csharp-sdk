using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<UpdateNotificationsRequestStatus>))]
[Serializable]
public readonly record struct UpdateNotificationsRequestStatus : IStringEnum
{
    public static readonly UpdateNotificationsRequestStatus Read = new(Values.Read);

    public static readonly UpdateNotificationsRequestStatus Unread = new(Values.Unread);

    public static readonly UpdateNotificationsRequestStatus Dismissed = new(Values.Dismissed);

    public static readonly UpdateNotificationsRequestStatus Archived = new(Values.Archived);

    public UpdateNotificationsRequestStatus(string value)
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
    public static UpdateNotificationsRequestStatus FromCustom(string value)
    {
        return new UpdateNotificationsRequestStatus(value);
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

    public static bool operator ==(UpdateNotificationsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateNotificationsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateNotificationsRequestStatus value) => value.Value;

    public static explicit operator UpdateNotificationsRequestStatus(string value) => new(value);

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
