namespace ForuMsApi;

public partial interface IUsersClient
{
    Task<GetUsersResponse> ListAllUsersAsync(
        GetUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetUsersIdResponse> GetAUserAsync(
        GetUsersIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteUsersIdResponse> DeleteAUserAsync(
        DeleteUsersIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchUsersIdResponse> UpdateAUserAsync(
        PatchUsersIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetUsersIdFollowersResponse> ListUserFollowersAsync(
        GetUsersIdFollowersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetUsersIdFollowersSubIdResponse> GetAFollowerFromUserAsync(
        GetUsersIdFollowersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteUsersIdFollowersSubIdResponse> DeleteAFollowerFromUserAsync(
        DeleteUsersIdFollowersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetUsersIdFollowingResponse> ListUserFollowingAsync(
        GetUsersIdFollowingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetUsersIdFollowingSubIdResponse> GetAFollowingFromUserAsync(
        GetUsersIdFollowingSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteUsersIdFollowingSubIdResponse> DeleteAFollowingFromUserAsync(
        DeleteUsersIdFollowingSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
