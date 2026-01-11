namespace ForuMsApi;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class ForuMsApiException(string message, Exception? innerException = null)
    : Exception(message, innerException);
