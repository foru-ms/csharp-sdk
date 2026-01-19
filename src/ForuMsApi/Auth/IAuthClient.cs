namespace ForuMsApi;

public partial interface IAuthClient
{
    /// <summary>
    /// Register a new user in your forum instance. Requires API key for instance identification. Returns a JWT token for subsequent authenticated requests.
    /// </summary>
    Task<RegisterResponse> RegisterAsync(
        RegisterAuthRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Authenticate an existing user. Requires API key for instance identification. Returns a JWT token for subsequent authenticated requests.
    /// </summary>
    Task<LoginResponse> LoginAsync(
        LoginAuthRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<MeResponse> MeAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Request a password reset email. Requires API key for instance identification.
    /// </summary>
    Task<ForgotPasswordResponse> ForgotPasswordAsync(
        ForgotPasswordAuthRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reset password using a reset token. Requires API key for instance identification.
    /// </summary>
    Task<ResetPasswordResponse> ResetPasswordAsync(
        ResetPasswordAuthRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
