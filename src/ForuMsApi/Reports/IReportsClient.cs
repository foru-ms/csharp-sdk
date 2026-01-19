namespace ForuMsApi;

public partial interface IReportsClient
{
    /// <summary>
    /// Retrieve a paginated list of reports. Use cursor for pagination.
    /// </summary>
    Task<ReportListResponse> ListAsync(
        ListReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new report.
    /// </summary>
    Task<ReportResponse> CreateAsync(
        CreateReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a report by ID or slug (if supported).
    /// </summary>
    Task<ReportResponse> RetrieveAsync(
        RetrieveReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete a report.
    /// </summary>
    Task<SuccessResponse> DeleteAsync(
        DeleteReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an existing report. Only provided fields will be modified.
    /// </summary>
    Task<UpdateReportsResponse> UpdateAsync(
        UpdateReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
