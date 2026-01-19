using System.Text.Json.Serialization;
using ForuMsApi.Core;

namespace ForuMsApi;

[JsonConverter(typeof(StringEnumSerializer<SearchSearchResponseDataItemsItemType>))]
[Serializable]
public readonly record struct SearchSearchResponseDataItemsItemType : IStringEnum
{
    public static readonly SearchSearchResponseDataItemsItemType Thread = new(Values.Thread);

    public static readonly SearchSearchResponseDataItemsItemType Post = new(Values.Post);

    public static readonly SearchSearchResponseDataItemsItemType User = new(Values.User);

    public static readonly SearchSearchResponseDataItemsItemType Tag = new(Values.Tag);

    public SearchSearchResponseDataItemsItemType(string value)
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
    public static SearchSearchResponseDataItemsItemType FromCustom(string value)
    {
        return new SearchSearchResponseDataItemsItemType(value);
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

    public static bool operator ==(SearchSearchResponseDataItemsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SearchSearchResponseDataItemsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SearchSearchResponseDataItemsItemType value) =>
        value.Value;

    public static explicit operator SearchSearchResponseDataItemsItemType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Thread = "thread";

        public const string Post = "post";

        public const string User = "user";

        public const string Tag = "tag";
    }
}
