namespace ForuMsApi;

public partial interface IReportsClient
{
    Task<GetReportsResponse> ListAllReportsAsync(
        GetReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostReportsResponse> CreateAReportAsync(
        PostReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetReportsIdResponse> GetAReportAsync(
        GetReportsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteReportsIdResponse> DeleteAReportAsync(
        DeleteReportsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
