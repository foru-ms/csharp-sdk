using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<PostNotificationsRequestStatus>))]
[Serializable]
public readonly record struct PostNotificationsRequestStatus : IStringEnum
{
    public static readonly PostNotificationsRequestStatus Read = new(Values.Read);

    public static readonly PostNotificationsRequestStatus Unread = new(Values.Unread);

    public static readonly PostNotificationsRequestStatus Dismissed = new(Values.Dismissed);

    public static readonly PostNotificationsRequestStatus Archived = new(Values.Archived);

    public PostNotificationsRequestStatus(string value)
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
    public static PostNotificationsRequestStatus FromCustom(string value)
    {
        return new PostNotificationsRequestStatus(value);
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

    public static bool operator ==(PostNotificationsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostNotificationsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostNotificationsRequestStatus value) => value.Value;

    public static explicit operator PostNotificationsRequestStatus(string value) => new(value);

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
