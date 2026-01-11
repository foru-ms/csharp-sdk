using System.Text.Json.Serialization;

namespace ForuMsApi.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
