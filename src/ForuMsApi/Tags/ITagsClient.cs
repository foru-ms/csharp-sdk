namespace ForuMsApi;

public partial interface ITagsClient
{
    Task<GetTagsResponse> ListAllTagsAsync(
        GetTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PostTagsResponse> CreateATagAsync(
        PostTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetTagsIdResponse> GetATagAsync(
        GetTagsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteTagsIdResponse> DeleteATagAsync(
        DeleteTagsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<PatchTagsIdResponse> UpdateATagAsync(
        PatchTagsIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetTagsIdSubscribersResponse> ListTagSubscribersAsync(
        GetTagsIdSubscribersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<GetTagsIdSubscribersSubIdResponse> GetASubscriberFromTagAsync(
        GetTagsIdSubscribersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task<DeleteTagsIdSubscribersSubIdResponse> DeleteASubscriberFromTagAsync(
        DeleteTagsIdSubscribersSubIdRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
