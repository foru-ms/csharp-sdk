namespace ForuMsApi;

public partial interface IRolesClient
{
    Task<GetRolesResponse> ListAllRolesAsync(
        GetRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostRolesResponse> CreateARoleAsync(
        PostRolesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetRolesIdResponse> GetARoleAsync(
        GetRolesIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteRolesIdResponse> DeleteARoleAsync(
        DeleteRolesIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchRolesIdResponse> UpdateARoleAsync(
        PatchRolesIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
