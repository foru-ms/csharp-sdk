# Reference
## Auth
<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">RegisterAsync</a>(PostAuthRegisterRequest { ... }) -> PostAuthRegisterResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.RegisterAsync(
    new PostAuthRegisterRequest
    {
        Username = "username",
        Email = "email",
        Password = "password",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAuthRegisterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">LoginAsync</a>(PostAuthLoginRequest { ... }) -> PostAuthLoginResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.LoginAsync(new PostAuthLoginRequest { Login = "login", Password = "password" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAuthLoginRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">GetCurrentUserAsync</a>() -> GetAuthMeResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.GetCurrentUserAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">RequestPasswordResetAsync</a>(PostAuthForgotPasswordRequest { ... }) -> PostAuthForgotPasswordResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.RequestPasswordResetAsync(new PostAuthForgotPasswordRequest { Email = "email" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAuthForgotPasswordRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">ResetPasswordAsync</a>(PostAuthResetPasswordRequest { ... }) -> PostAuthResetPasswordResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.ResetPasswordAsync(new PostAuthResetPasswordRequest { Password = "password" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostAuthResetPasswordRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tags
<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">ListAllTagsAsync</a>(GetTagsRequest { ... }) -> GetTagsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.ListAllTagsAsync(new GetTagsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">CreateATagAsync</a>(PostTagsRequest { ... }) -> PostTagsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.CreateATagAsync(new PostTagsRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">GetATagAsync</a>(GetTagsIdRequest { ... }) -> GetTagsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.GetATagAsync(new GetTagsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTagsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">DeleteATagAsync</a>(DeleteTagsIdRequest { ... }) -> DeleteTagsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.DeleteATagAsync(new DeleteTagsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteTagsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">UpdateATagAsync</a>(PatchTagsIdRequest { ... }) -> PatchTagsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.UpdateATagAsync(new PatchTagsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchTagsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">ListTagSubscribersAsync</a>(GetTagsIdSubscribersRequest { ... }) -> GetTagsIdSubscribersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.ListTagSubscribersAsync(new GetTagsIdSubscribersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTagsIdSubscribersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">GetASubscriberFromTagAsync</a>(GetTagsIdSubscribersSubIdRequest { ... }) -> GetTagsIdSubscribersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.GetASubscriberFromTagAsync(
    new GetTagsIdSubscribersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTagsIdSubscribersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">DeleteASubscriberFromTagAsync</a>(DeleteTagsIdSubscribersSubIdRequest { ... }) -> DeleteTagsIdSubscribersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.DeleteASubscriberFromTagAsync(
    new DeleteTagsIdSubscribersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteTagsIdSubscribersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Threads
<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListAllThreadsAsync</a>(GetThreadsRequest { ... }) -> GetThreadsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.ListAllThreadsAsync(new GetThreadsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreateAThreadAsync</a>(PostThreadsRequest { ... }) -> PostThreadsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.CreateAThreadAsync(new PostThreadsRequest { Title = "title", Body = "body" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">GetAThreadAsync</a>(GetThreadsIdRequest { ... }) -> GetThreadsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.GetAThreadAsync(new GetThreadsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteAThreadAsync</a>(DeleteThreadsIdRequest { ... }) -> DeleteThreadsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteAThreadAsync(new DeleteThreadsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteThreadsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">UpdateAThreadAsync</a>(PatchThreadsIdRequest { ... }) -> PatchThreadsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.UpdateAThreadAsync(new PatchThreadsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchThreadsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListThreadPostsAsync</a>(GetThreadsIdPostsRequest { ... }) -> GetThreadsIdPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.ListThreadPostsAsync(new GetThreadsIdPostsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">GetAPostFromThreadAsync</a>(GetThreadsIdPostsSubIdRequest { ... }) -> GetThreadsIdPostsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.GetAPostFromThreadAsync(
    new GetThreadsIdPostsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdPostsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteAPostFromThreadAsync</a>(DeleteThreadsIdPostsSubIdRequest { ... }) -> DeleteThreadsIdPostsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteAPostFromThreadAsync(
    new DeleteThreadsIdPostsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteThreadsIdPostsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListThreadReactionsAsync</a>(GetThreadsIdReactionsRequest { ... }) -> GetThreadsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.ListThreadReactionsAsync(new GetThreadsIdReactionsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreateAReactionInThreadAsync</a>(PostThreadsIdReactionsRequest { ... }) -> PostThreadsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.CreateAReactionInThreadAsync(
    new PostThreadsIdReactionsRequest { Id = "id", Type = PostThreadsIdReactionsRequestType.Like }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostThreadsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RemoveYourReactionFromThreadAsync</a>(DeleteThreadsIdReactionsRequest { ... }) -> DeleteThreadsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the authenticated user's reaction. No subId needed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.RemoveYourReactionFromThreadAsync(
    new DeleteThreadsIdReactionsRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteThreadsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">GetAReactionFromThreadAsync</a>(GetThreadsIdReactionsSubIdRequest { ... }) -> GetThreadsIdReactionsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.GetAReactionFromThreadAsync(
    new GetThreadsIdReactionsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdReactionsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteAReactionFromThreadAsync</a>(DeleteThreadsIdReactionsSubIdRequest { ... }) -> DeleteThreadsIdReactionsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteAReactionFromThreadAsync(
    new DeleteThreadsIdReactionsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteThreadsIdReactionsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListThreadSubscribersAsync</a>(GetThreadsIdSubscribersRequest { ... }) -> GetThreadsIdSubscribersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.ListThreadSubscribersAsync(new GetThreadsIdSubscribersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdSubscribersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">GetASubscriberFromThreadAsync</a>(GetThreadsIdSubscribersSubIdRequest { ... }) -> GetThreadsIdSubscribersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.GetASubscriberFromThreadAsync(
    new GetThreadsIdSubscribersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdSubscribersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteASubscriberFromThreadAsync</a>(DeleteThreadsIdSubscribersSubIdRequest { ... }) -> DeleteThreadsIdSubscribersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteASubscriberFromThreadAsync(
    new DeleteThreadsIdSubscribersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteThreadsIdSubscribersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">GetThreadPollAsync</a>(GetThreadsIdPollRequest { ... }) -> GetThreadsIdPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.GetThreadPollAsync(new GetThreadsIdPollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetThreadsIdPollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreateThreadPollAsync</a>(PostThreadsIdPollRequest { ... }) -> PostThreadsIdPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.CreateThreadPollAsync(
    new PostThreadsIdPollRequest
    {
        Id = "id",
        Title = "title",
        Options = new List<PostThreadsIdPollRequestOptionsItem>()
        {
            new PostThreadsIdPollRequestOptionsItem { Title = "title" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostThreadsIdPollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">UpdateThreadPollAsync</a>(PatchThreadsIdPollRequest { ... }) -> PatchThreadsIdPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.UpdateThreadPollAsync(new PatchThreadsIdPollRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchThreadsIdPollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Posts
<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListAllPostsAsync</a>(GetPostsRequest { ... }) -> GetPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.ListAllPostsAsync(new GetPostsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">CreateAPostAsync</a>(PostPostsRequest { ... }) -> PostPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.CreateAPostAsync(new PostPostsRequest { ThreadId = "threadId", Body = "body" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">GetAPostAsync</a>(GetPostsIdRequest { ... }) -> GetPostsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.GetAPostAsync(new GetPostsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeleteAPostAsync</a>(DeletePostsIdRequest { ... }) -> DeletePostsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.DeleteAPostAsync(new DeletePostsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePostsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">UpdateAPostAsync</a>(PatchPostsIdRequest { ... }) -> PatchPostsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.UpdateAPostAsync(new PatchPostsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchPostsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListPostReactionsAsync</a>(GetPostsIdReactionsRequest { ... }) -> GetPostsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.ListPostReactionsAsync(new GetPostsIdReactionsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">CreateAReactionInPostAsync</a>(PostPostsIdReactionsRequest { ... }) -> PostPostsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.CreateAReactionInPostAsync(
    new PostPostsIdReactionsRequest { Id = "id", Type = PostPostsIdReactionsRequestType.Like }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostPostsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">RemoveYourReactionFromPostAsync</a>(DeletePostsIdReactionsRequest { ... }) -> DeletePostsIdReactionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the authenticated user's reaction. No subId needed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.RemoveYourReactionFromPostAsync(new DeletePostsIdReactionsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePostsIdReactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">GetAReactionFromPostAsync</a>(GetPostsIdReactionsSubIdRequest { ... }) -> GetPostsIdReactionsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.GetAReactionFromPostAsync(
    new GetPostsIdReactionsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsIdReactionsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeleteAReactionFromPostAsync</a>(DeletePostsIdReactionsSubIdRequest { ... }) -> DeletePostsIdReactionsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.DeleteAReactionFromPostAsync(
    new DeletePostsIdReactionsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePostsIdReactionsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListPostPostsAsync</a>(GetPostsIdPostsRequest { ... }) -> GetPostsIdPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.ListPostPostsAsync(new GetPostsIdPostsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsIdPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">GetAPostFromPostAsync</a>(GetPostsIdPostsSubIdRequest { ... }) -> GetPostsIdPostsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.GetAPostFromPostAsync(
    new GetPostsIdPostsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPostsIdPostsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeleteAPostFromPostAsync</a>(DeletePostsIdPostsSubIdRequest { ... }) -> DeletePostsIdPostsSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.DeleteAPostFromPostAsync(
    new DeletePostsIdPostsSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePostsIdPostsSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PrivateMessages
<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">ListAllPrivateMessagesAsync</a>(GetPrivateMessagesRequest { ... }) -> GetPrivateMessagesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.ListAllPrivateMessagesAsync(new GetPrivateMessagesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">CreateAPrivateMessageAsync</a>(PostPrivateMessagesRequest { ... }) -> PostPrivateMessagesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.CreateAPrivateMessageAsync(
    new PostPrivateMessagesRequest { RecipientId = "recipientId", Body = "body" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">GetAPrivateMessageAsync</a>(GetPrivateMessagesIdRequest { ... }) -> GetPrivateMessagesIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.GetAPrivateMessageAsync(new GetPrivateMessagesIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPrivateMessagesIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">DeleteAPrivateMessageAsync</a>(DeletePrivateMessagesIdRequest { ... }) -> DeletePrivateMessagesIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.DeleteAPrivateMessageAsync(
    new DeletePrivateMessagesIdRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePrivateMessagesIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">ListPrivateMessageRepliesAsync</a>(GetPrivateMessagesIdRepliesRequest { ... }) -> GetPrivateMessagesIdRepliesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.ListPrivateMessageRepliesAsync(
    new GetPrivateMessagesIdRepliesRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPrivateMessagesIdRepliesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">CreateAReplyInPrivateMessageAsync</a>(PostPrivateMessagesIdRepliesRequest { ... }) -> PostPrivateMessagesIdRepliesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.CreateAReplyInPrivateMessageAsync(
    new PostPrivateMessagesIdRepliesRequest
    {
        Id = "id",
        RecipientId = "recipientId",
        Body = "body",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostPrivateMessagesIdRepliesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">GetAReplyFromPrivateMessageAsync</a>(GetPrivateMessagesIdRepliesSubIdRequest { ... }) -> GetPrivateMessagesIdRepliesSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.GetAReplyFromPrivateMessageAsync(
    new GetPrivateMessagesIdRepliesSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetPrivateMessagesIdRepliesSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">DeleteAReplyFromPrivateMessageAsync</a>(DeletePrivateMessagesIdRepliesSubIdRequest { ... }) -> DeletePrivateMessagesIdRepliesSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.DeleteAReplyFromPrivateMessageAsync(
    new DeletePrivateMessagesIdRepliesSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeletePrivateMessagesIdRepliesSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Users
<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListAllUsersAsync</a>(GetUsersRequest { ... }) -> GetUsersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListAllUsersAsync(new GetUsersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">GetAUserAsync</a>(GetUsersIdRequest { ... }) -> GetUsersIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.GetAUserAsync(new GetUsersIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteAUserAsync</a>(DeleteUsersIdRequest { ... }) -> DeleteUsersIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteAUserAsync(new DeleteUsersIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteUsersIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">UpdateAUserAsync</a>(PatchUsersIdRequest { ... }) -> PatchUsersIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.UpdateAUserAsync(new PatchUsersIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchUsersIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListUserFollowersAsync</a>(GetUsersIdFollowersRequest { ... }) -> GetUsersIdFollowersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListUserFollowersAsync(new GetUsersIdFollowersRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersIdFollowersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">GetAFollowerFromUserAsync</a>(GetUsersIdFollowersSubIdRequest { ... }) -> GetUsersIdFollowersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.GetAFollowerFromUserAsync(
    new GetUsersIdFollowersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersIdFollowersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteAFollowerFromUserAsync</a>(DeleteUsersIdFollowersSubIdRequest { ... }) -> DeleteUsersIdFollowersSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteAFollowerFromUserAsync(
    new DeleteUsersIdFollowersSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteUsersIdFollowersSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListUserFollowingAsync</a>(GetUsersIdFollowingRequest { ... }) -> GetUsersIdFollowingResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListUserFollowingAsync(new GetUsersIdFollowingRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersIdFollowingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">GetAFollowingFromUserAsync</a>(GetUsersIdFollowingSubIdRequest { ... }) -> GetUsersIdFollowingSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.GetAFollowingFromUserAsync(
    new GetUsersIdFollowingSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUsersIdFollowingSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteAFollowingFromUserAsync</a>(DeleteUsersIdFollowingSubIdRequest { ... }) -> DeleteUsersIdFollowingSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteAFollowingFromUserAsync(
    new DeleteUsersIdFollowingSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteUsersIdFollowingSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Roles
<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">ListAllRolesAsync</a>(GetRolesRequest { ... }) -> GetRolesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.ListAllRolesAsync(new GetRolesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">CreateARoleAsync</a>(PostRolesRequest { ... }) -> PostRolesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.CreateARoleAsync(new PostRolesRequest { Name = "name" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">GetARoleAsync</a>(GetRolesIdRequest { ... }) -> GetRolesIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.GetARoleAsync(new GetRolesIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetRolesIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">DeleteARoleAsync</a>(DeleteRolesIdRequest { ... }) -> DeleteRolesIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.DeleteARoleAsync(new DeleteRolesIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteRolesIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">UpdateARoleAsync</a>(PatchRolesIdRequest { ... }) -> PatchRolesIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Roles.UpdateARoleAsync(new PatchRolesIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchRolesIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports
<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">ListAllReportsAsync</a>(GetReportsRequest { ... }) -> GetReportsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.ListAllReportsAsync(new GetReportsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">CreateAReportAsync</a>(PostReportsRequest { ... }) -> PostReportsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.CreateAReportAsync(new PostReportsRequest { Type = "type" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">GetAReportAsync</a>(GetReportsIdRequest { ... }) -> GetReportsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.GetAReportAsync(new GetReportsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetReportsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">DeleteAReportAsync</a>(DeleteReportsIdRequest { ... }) -> DeleteReportsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.DeleteAReportAsync(new DeleteReportsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteReportsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Notifications
<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">ListAllNotificationsAsync</a>(GetNotificationsRequest { ... }) -> GetNotificationsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Notifications.ListAllNotificationsAsync(new GetNotificationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">CreateANotificationAsync</a>(PostNotificationsRequest { ... }) -> PostNotificationsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Notifications.CreateANotificationAsync(
    new PostNotificationsRequest { UserId = "userId", Type = "type" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">GetANotificationAsync</a>(GetNotificationsIdRequest { ... }) -> GetNotificationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Notifications.GetANotificationAsync(new GetNotificationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetNotificationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">DeleteANotificationAsync</a>(DeleteNotificationsIdRequest { ... }) -> DeleteNotificationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Notifications.DeleteANotificationAsync(new DeleteNotificationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteNotificationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">UpdateANotificationAsync</a>(PatchNotificationsIdRequest { ... }) -> PatchNotificationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Notifications.UpdateANotificationAsync(new PatchNotificationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchNotificationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">ListAllWebhooksAsync</a>(GetWebhooksRequest { ... }) -> GetWebhooksResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.ListAllWebhooksAsync(new GetWebhooksRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">CreateAWebhookAsync</a>(PostWebhooksRequest { ... }) -> PostWebhooksResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.CreateAWebhookAsync(
    new PostWebhooksRequest
    {
        Name = "name",
        Url = "url",
        Events = new List<string>() { "events" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">GetAWebhookAsync</a>(GetWebhooksIdRequest { ... }) -> GetWebhooksIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.GetAWebhookAsync(new GetWebhooksIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetWebhooksIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">DeleteAWebhookAsync</a>(DeleteWebhooksIdRequest { ... }) -> DeleteWebhooksIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeleteAWebhookAsync(new DeleteWebhooksIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteWebhooksIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">ListWebhookDeliveriesAsync</a>(GetWebhooksIdDeliveriesRequest { ... }) -> GetWebhooksIdDeliveriesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.ListWebhookDeliveriesAsync(new GetWebhooksIdDeliveriesRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetWebhooksIdDeliveriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">GetADeliveryFromWebhookAsync</a>(GetWebhooksIdDeliveriesSubIdRequest { ... }) -> GetWebhooksIdDeliveriesSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.GetADeliveryFromWebhookAsync(
    new GetWebhooksIdDeliveriesSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetWebhooksIdDeliveriesSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">DeleteADeliveryFromWebhookAsync</a>(DeleteWebhooksIdDeliveriesSubIdRequest { ... }) -> DeleteWebhooksIdDeliveriesSubIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeleteADeliveryFromWebhookAsync(
    new DeleteWebhooksIdDeliveriesSubIdRequest { Id = "id", SubId = "subId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteWebhooksIdDeliveriesSubIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Integrations
<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">ListAllIntegrationsAsync</a>(GetIntegrationsRequest { ... }) -> GetIntegrationsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Integrations.ListAllIntegrationsAsync(new GetIntegrationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">CreateAnIntegrationAsync</a>(PostIntegrationsRequest { ... }) -> PostIntegrationsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Integrations.CreateAnIntegrationAsync(
    new PostIntegrationsRequest
    {
        Type = "type",
        Config = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">GetAnIntegrationAsync</a>(GetIntegrationsIdRequest { ... }) -> GetIntegrationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Integrations.GetAnIntegrationAsync(new GetIntegrationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetIntegrationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">DeleteAnIntegrationAsync</a>(DeleteIntegrationsIdRequest { ... }) -> DeleteIntegrationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Integrations.DeleteAnIntegrationAsync(new DeleteIntegrationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteIntegrationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">UpdateAnIntegrationAsync</a>(PatchIntegrationsIdRequest { ... }) -> PatchIntegrationsIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Integrations.UpdateAnIntegrationAsync(new PatchIntegrationsIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchIntegrationsIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SsOs
<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">ListAllSsOsAsync</a>(GetSsoRequest { ... }) -> GetSsoResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SsOs.ListAllSsOsAsync(new GetSsoRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSsoRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">CreateAnSsoAsync</a>(PostSsoRequest { ... }) -> PostSsoResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SsOs.CreateAnSsoAsync(
    new PostSsoRequest
    {
        Name = "name",
        ClientId = "clientId",
        ClientSecret = "clientSecret",
        Issuer = "issuer",
        AuthorizationEndpoint = "authorizationEndpoint",
        TokenEndpoint = "tokenEndpoint",
        UserInfoEndpoint = "userInfoEndpoint",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostSsoRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">GetAnSsoAsync</a>(GetSsoIdRequest { ... }) -> GetSsoIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SsOs.GetAnSsoAsync(new GetSsoIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSsoIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">DeleteAnSsoAsync</a>(DeleteSsoIdRequest { ... }) -> DeleteSsoIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SsOs.DeleteAnSsoAsync(new DeleteSsoIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSsoIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">UpdateAnSsoAsync</a>(PatchSsoIdRequest { ... }) -> PatchSsoIdResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SsOs.UpdateAnSsoAsync(new PatchSsoIdRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatchSsoIdRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
