namespace ForuMsApi;

public partial interface IAuthClient
{
    Task<PostAuthRegisterResponse> RegisterAsync(
        PostAuthRegisterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostAuthLoginResponse> LoginAsync(
        PostAuthLoginRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetAuthMeResponse> GetCurrentUserAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostAuthForgotPasswordResponse> RequestPasswordResetAsync(
        PostAuthForgotPasswordRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostAuthResetPasswordResponse> ResetPasswordAsync(
        PostAuthResetPasswordRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
