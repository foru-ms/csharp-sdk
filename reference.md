# Reference
## Auth
<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">RegisterAsync</a>(RegisterAuthRequest { ... }) -> RegisterResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Register a new user in your forum instance. Requires API key for instance identification. Returns a JWT token for subsequent authenticated requests.
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
await client.Auth.RegisterAsync(
    new RegisterAuthRequest
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

**request:** `RegisterAuthRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">LoginAsync</a>(LoginAuthRequest { ... }) -> LoginResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Authenticate an existing user. Requires API key for instance identification. Returns a JWT token for subsequent authenticated requests.
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
await client.Auth.LoginAsync(new LoginAuthRequest { Login = "login", Password = "password" });
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

**request:** `LoginAuthRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">MeAsync</a>() -> MeResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.MeAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">ForgotPasswordAsync</a>(ForgotPasswordAuthRequest { ... }) -> ForgotPasswordResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Request a password reset email. Requires API key for instance identification.
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
await client.Auth.ForgotPasswordAsync(new ForgotPasswordAuthRequest { Email = "email" });
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

**request:** `ForgotPasswordAuthRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.<a href="/src/ForuMsApi/Auth/AuthClient.cs">ResetPasswordAsync</a>(ResetPasswordAuthRequest { ... }) -> ResetPasswordResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reset password using a reset token. Requires API key for instance identification.
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
await client.Auth.ResetPasswordAsync(new ResetPasswordAuthRequest { Password = "password" });
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

**request:** `ResetPasswordAuthRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Search
<details><summary><code>client.Search.<a href="/src/ForuMsApi/Search/SearchClient.cs">SearchAsync</a>() -> SearchSearchResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Search.SearchAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tags
<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">ListAsync</a>(ListTagsRequest { ... }) -> TagListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of tags. Use cursor for pagination.
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
await client.Tags.ListAsync(new ListTagsRequest());
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

**request:** `ListTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">CreateAsync</a>(CreateTagsRequest { ... }) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new tag.
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
await client.Tags.CreateAsync(new CreateTagsRequest { Name = "name" });
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

**request:** `CreateTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">RetrieveAsync</a>(RetrieveTagsRequest { ... }) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a tag by ID or slug (if supported).
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
await client.Tags.RetrieveAsync(new RetrieveTagsRequest { Id = "id" });
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

**request:** `RetrieveTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">DeleteAsync</a>(DeleteTagsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a tag.
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
await client.Tags.DeleteAsync(new DeleteTagsRequest { Id = "id" });
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

**request:** `DeleteTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">UpdateAsync</a>(UpdateTagsRequest { ... }) -> UpdateTagsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing tag. Only provided fields will be modified.
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
await client.Tags.UpdateAsync(new UpdateTagsRequest { Id = "id" });
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

**request:** `UpdateTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">ListSubscribersAsync</a>(ListSubscribersTagsRequest { ... }) -> TagSubscriberListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of subscribers for Tag.
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
await client.Tags.ListSubscribersAsync(new ListSubscribersTagsRequest { Id = "id" });
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

**request:** `ListSubscribersTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">RetrieveSubscriberAsync</a>(RetrieveSubscriberTagsRequest { ... }) -> RetrieveSubscriberTagsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.RetrieveSubscriberAsync(
    new RetrieveSubscriberTagsRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveSubscriberTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/ForuMsApi/Tags/TagsClient.cs">DeleteSubscriberAsync</a>(DeleteSubscriberTagsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.DeleteSubscriberAsync(
    new DeleteSubscriberTagsRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteSubscriberTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Threads
<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListAsync</a>(ListThreadsRequest { ... }) -> ThreadListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of threads. Use cursor for pagination.
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
await client.Threads.ListAsync(new ListThreadsRequest());
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

**request:** `ListThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreateAsync</a>(CreateThreadsRequest { ... }) -> ThreadResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new thread.
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
await client.Threads.CreateAsync(new CreateThreadsRequest { Title = "title", Body = "body" });
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

**request:** `CreateThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RetrieveAsync</a>(RetrieveThreadsRequest { ... }) -> ThreadResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a thread by ID or slug (if supported).
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
await client.Threads.RetrieveAsync(new RetrieveThreadsRequest { Id = "id" });
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

**request:** `RetrieveThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteAsync</a>(DeleteThreadsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a thread.
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
await client.Threads.DeleteAsync(new DeleteThreadsRequest { Id = "id" });
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

**request:** `DeleteThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">UpdateAsync</a>(UpdateThreadsRequest { ... }) -> UpdateThreadsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing thread. Only provided fields will be modified.
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
await client.Threads.UpdateAsync(new UpdateThreadsRequest { Id = "id" });
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

**request:** `UpdateThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListPostsAsync</a>(ListPostsThreadsRequest { ... }) -> ThreadPostListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of posts for Thread.
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
await client.Threads.ListPostsAsync(new ListPostsThreadsRequest { Id = "id" });
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

**request:** `ListPostsThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RetrievePostAsync</a>(RetrievePostThreadsRequest { ... }) -> RetrievePostThreadsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.RetrievePostAsync(
    new RetrievePostThreadsRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrievePostThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeletePostAsync</a>(DeletePostThreadsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeletePostAsync(new DeletePostThreadsRequest { Id = "id", SubId = "subId" });
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

**request:** `DeletePostThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListReactionsAsync</a>(ListReactionsThreadsRequest { ... }) -> ThreadReactionListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of reactions for Thread.
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
await client.Threads.ListReactionsAsync(new ListReactionsThreadsRequest { Id = "id" });
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

**request:** `ListReactionsThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreateReactionAsync</a>(CreateReactionThreadsRequest { ... }) -> ThreadReactionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a Reaction in Thread.
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
await client.Threads.CreateReactionAsync(
    new CreateReactionThreadsRequest { Id = "id", Type = CreateReactionThreadsRequestType.Like }
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

**request:** `CreateReactionThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteReactionAsync</a>(DeleteReactionThreadsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteReactionAsync(
    new DeleteReactionThreadsRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteReactionThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RetrieveReactionAsync</a>(RetrieveReactionThreadsRequest { ... }) -> RetrieveReactionThreadsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.RetrieveReactionAsync(
    new RetrieveReactionThreadsRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveReactionThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">ListSubscribersAsync</a>(ListSubscribersThreadsRequest { ... }) -> ThreadSubscriberListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of subscribers for Thread.
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
await client.Threads.ListSubscribersAsync(new ListSubscribersThreadsRequest { Id = "id" });
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

**request:** `ListSubscribersThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RetrieveSubscriberAsync</a>(RetrieveSubscriberThreadsRequest { ... }) -> RetrieveSubscriberThreadsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.RetrieveSubscriberAsync(
    new RetrieveSubscriberThreadsRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveSubscriberThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">DeleteSubscriberAsync</a>(DeleteSubscriberThreadsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.DeleteSubscriberAsync(
    new DeleteSubscriberThreadsRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteSubscriberThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">RetrievePollAsync</a>(RetrievePollThreadsRequest { ... }) -> ThreadPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.RetrievePollAsync(new RetrievePollThreadsRequest { Id = "id" });
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

**request:** `RetrievePollThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">CreatePollAsync</a>(CreatePollThreadsRequest { ... }) -> ThreadPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.CreatePollAsync(
    new CreatePollThreadsRequest
    {
        Id = "id",
        Title = "title",
        Options = new List<CreatePollThreadsRequestOptionsItem>()
        {
            new CreatePollThreadsRequestOptionsItem { Title = "title" },
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

**request:** `CreatePollThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Threads.<a href="/src/ForuMsApi/Threads/ThreadsClient.cs">UpdatePollAsync</a>(UpdatePollThreadsRequest { ... }) -> ThreadPollResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Threads.UpdatePollAsync(new UpdatePollThreadsRequest { Id = "id" });
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

**request:** `UpdatePollThreadsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Posts
<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListAsync</a>(ListPostsRequest { ... }) -> PostListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of posts. Use cursor for pagination.
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
await client.Posts.ListAsync(new ListPostsRequest());
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

**request:** `ListPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">CreateAsync</a>(CreatePostsRequest { ... }) -> PostResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new post.
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
await client.Posts.CreateAsync(new CreatePostsRequest { ThreadId = "threadId", Body = "body" });
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

**request:** `CreatePostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">RetrieveAsync</a>(RetrievePostsRequest { ... }) -> PostResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a post by ID or slug (if supported).
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
await client.Posts.RetrieveAsync(new RetrievePostsRequest { Id = "id" });
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

**request:** `RetrievePostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeleteAsync</a>(DeletePostsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a post.
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
await client.Posts.DeleteAsync(new DeletePostsRequest { Id = "id" });
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

**request:** `DeletePostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">UpdateAsync</a>(UpdatePostsRequest { ... }) -> UpdatePostsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing post. Only provided fields will be modified.
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
await client.Posts.UpdateAsync(new UpdatePostsRequest { Id = "id" });
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

**request:** `UpdatePostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListReactionsAsync</a>(ListReactionsPostsRequest { ... }) -> PostReactionListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of reactions for Post.
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
await client.Posts.ListReactionsAsync(new ListReactionsPostsRequest { Id = "id" });
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

**request:** `ListReactionsPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">CreateReactionAsync</a>(CreateReactionPostsRequest { ... }) -> PostReactionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a Reaction in Post.
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
await client.Posts.CreateReactionAsync(
    new CreateReactionPostsRequest { Id = "id", Type = CreateReactionPostsRequestType.Like }
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

**request:** `CreateReactionPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeleteReactionAsync</a>(DeleteReactionPostsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.DeleteReactionAsync(
    new DeleteReactionPostsRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteReactionPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">RetrieveReactionAsync</a>(RetrieveReactionPostsRequest { ... }) -> RetrieveReactionPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.RetrieveReactionAsync(
    new RetrieveReactionPostsRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveReactionPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">ListPostsAsync</a>(ListPostsPostsRequest { ... }) -> PostPostListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of posts for Post.
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
await client.Posts.ListPostsAsync(new ListPostsPostsRequest { Id = "id" });
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

**request:** `ListPostsPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">RetrievePostAsync</a>(RetrievePostPostsRequest { ... }) -> RetrievePostPostsResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.RetrievePostAsync(new RetrievePostPostsRequest { Id = "id", SubId = "subId" });
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

**request:** `RetrievePostPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Posts.<a href="/src/ForuMsApi/Posts/PostsClient.cs">DeletePostAsync</a>(DeletePostPostsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Posts.DeletePostAsync(new DeletePostPostsRequest { Id = "id", SubId = "subId" });
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

**request:** `DeletePostPostsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Private Messages
<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">ListAsync</a>(ListPrivateMessagesRequest { ... }) -> PrivateMessageListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of private messages. Use cursor for pagination.
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
await client.PrivateMessages.ListAsync(new ListPrivateMessagesRequest());
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

**request:** `ListPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">CreateAsync</a>(CreatePrivateMessagesRequest { ... }) -> PrivateMessageResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new private message.
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
await client.PrivateMessages.CreateAsync(
    new CreatePrivateMessagesRequest { RecipientId = "recipientId", Body = "body" }
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

**request:** `CreatePrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">RetrieveAsync</a>(RetrievePrivateMessagesRequest { ... }) -> PrivateMessageResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a private message by ID or slug (if supported).
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
await client.PrivateMessages.RetrieveAsync(new RetrievePrivateMessagesRequest { Id = "id" });
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

**request:** `RetrievePrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">DeleteAsync</a>(DeletePrivateMessagesRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a private message.
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
await client.PrivateMessages.DeleteAsync(new DeletePrivateMessagesRequest { Id = "id" });
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

**request:** `DeletePrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">UpdateAsync</a>(UpdatePrivateMessagesRequest { ... }) -> UpdatePrivateMessagesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing private message. Only provided fields will be modified.
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
await client.PrivateMessages.UpdateAsync(new UpdatePrivateMessagesRequest { Id = "id" });
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

**request:** `UpdatePrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">ListRepliesAsync</a>(ListRepliesPrivateMessagesRequest { ... }) -> PrivateMessageReplyListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of replies for Private Message.
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
await client.PrivateMessages.ListRepliesAsync(new ListRepliesPrivateMessagesRequest { Id = "id" });
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

**request:** `ListRepliesPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">CreateReplyAsync</a>(CreateReplyPrivateMessagesRequest { ... }) -> PrivateMessageReplyResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a Reply in Private Message.
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
await client.PrivateMessages.CreateReplyAsync(
    new CreateReplyPrivateMessagesRequest
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

**request:** `CreateReplyPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">RetrieveReplyAsync</a>(RetrieveReplyPrivateMessagesRequest { ... }) -> RetrieveReplyPrivateMessagesResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.RetrieveReplyAsync(
    new RetrieveReplyPrivateMessagesRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveReplyPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PrivateMessages.<a href="/src/ForuMsApi/PrivateMessages/PrivateMessagesClient.cs">DeleteReplyAsync</a>(DeleteReplyPrivateMessagesRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PrivateMessages.DeleteReplyAsync(
    new DeleteReplyPrivateMessagesRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteReplyPrivateMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Users
<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListAsync</a>(ListUsersRequest { ... }) -> UserListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of users. Use cursor for pagination.
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
await client.Users.ListAsync(new ListUsersRequest());
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

**request:** `ListUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">CreateAsync</a>(CreateUsersRequest { ... }) -> UserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new user.
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
await client.Users.CreateAsync(new CreateUsersRequest { Username = "username" });
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

**request:** `CreateUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">RetrieveAsync</a>(RetrieveUsersRequest { ... }) -> UserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a user by ID or slug (if supported).
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
await client.Users.RetrieveAsync(new RetrieveUsersRequest { Id = "id" });
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

**request:** `RetrieveUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteAsync</a>(DeleteUsersRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a user.
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
await client.Users.DeleteAsync(new DeleteUsersRequest { Id = "id" });
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

**request:** `DeleteUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">UpdateAsync</a>(UpdateUsersRequest { ... }) -> UpdateUsersResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing user. Only provided fields will be modified.
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
await client.Users.UpdateAsync(new UpdateUsersRequest { Id = "id" });
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

**request:** `UpdateUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListFollowersAsync</a>(ListFollowersUsersRequest { ... }) -> UserFollowerListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of followers for User.
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
await client.Users.ListFollowersAsync(new ListFollowersUsersRequest { Id = "id" });
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

**request:** `ListFollowersUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">RetrieveFollowerAsync</a>(RetrieveFollowerUsersRequest { ... }) -> RetrieveFollowerUsersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.RetrieveFollowerAsync(
    new RetrieveFollowerUsersRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveFollowerUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteFollowerAsync</a>(DeleteFollowerUsersRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteFollowerAsync(
    new DeleteFollowerUsersRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteFollowerUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">ListFollowingAsync</a>(ListFollowingUsersRequest { ... }) -> UserFollowingListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of following for User.
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
await client.Users.ListFollowingAsync(new ListFollowingUsersRequest { Id = "id" });
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

**request:** `ListFollowingUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">RetrieveFollowingAsync</a>(RetrieveFollowingUsersRequest { ... }) -> RetrieveFollowingUsersResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.RetrieveFollowingAsync(
    new RetrieveFollowingUsersRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveFollowingUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/ForuMsApi/Users/UsersClient.cs">DeleteFollowingAsync</a>(DeleteFollowingUsersRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteFollowingAsync(
    new DeleteFollowingUsersRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteFollowingUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Roles
<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">ListAsync</a>(ListRolesRequest { ... }) -> RoleListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of roles. Use cursor for pagination.
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
await client.Roles.ListAsync(new ListRolesRequest());
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

**request:** `ListRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">CreateAsync</a>(CreateRolesRequest { ... }) -> RoleResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new role.
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
await client.Roles.CreateAsync(new CreateRolesRequest { Name = "name" });
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

**request:** `CreateRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">RetrieveAsync</a>(RetrieveRolesRequest { ... }) -> RoleResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a role by ID or slug (if supported).
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
await client.Roles.RetrieveAsync(new RetrieveRolesRequest { Id = "id" });
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

**request:** `RetrieveRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">DeleteAsync</a>(DeleteRolesRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a role.
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
await client.Roles.DeleteAsync(new DeleteRolesRequest { Id = "id" });
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

**request:** `DeleteRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Roles.<a href="/src/ForuMsApi/Roles/RolesClient.cs">UpdateAsync</a>(UpdateRolesRequest { ... }) -> UpdateRolesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing role. Only provided fields will be modified.
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
await client.Roles.UpdateAsync(new UpdateRolesRequest { Id = "id" });
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

**request:** `UpdateRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports
<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">ListAsync</a>(ListReportsRequest { ... }) -> ReportListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of reports. Use cursor for pagination.
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
await client.Reports.ListAsync(new ListReportsRequest());
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

**request:** `ListReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">CreateAsync</a>(CreateReportsRequest { ... }) -> ReportResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new report.
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
await client.Reports.CreateAsync(new CreateReportsRequest { Type = "type" });
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

**request:** `CreateReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">RetrieveAsync</a>(RetrieveReportsRequest { ... }) -> ReportResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a report by ID or slug (if supported).
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
await client.Reports.RetrieveAsync(new RetrieveReportsRequest { Id = "id" });
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

**request:** `RetrieveReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">DeleteAsync</a>(DeleteReportsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a report.
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
await client.Reports.DeleteAsync(new DeleteReportsRequest { Id = "id" });
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

**request:** `DeleteReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Reports.<a href="/src/ForuMsApi/Reports/ReportsClient.cs">UpdateAsync</a>(UpdateReportsRequest { ... }) -> UpdateReportsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing report. Only provided fields will be modified.
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
await client.Reports.UpdateAsync(new UpdateReportsRequest { Id = "id" });
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

**request:** `UpdateReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Notifications
<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">ListAsync</a>(ListNotificationsRequest { ... }) -> NotificationListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of notifications. Use cursor for pagination.
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
await client.Notifications.ListAsync(new ListNotificationsRequest());
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

**request:** `ListNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">CreateAsync</a>(CreateNotificationsRequest { ... }) -> NotificationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new notification.
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
await client.Notifications.CreateAsync(
    new CreateNotificationsRequest { UserId = "userId", Type = "type" }
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

**request:** `CreateNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">RetrieveAsync</a>(RetrieveNotificationsRequest { ... }) -> NotificationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a notification by ID or slug (if supported).
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
await client.Notifications.RetrieveAsync(new RetrieveNotificationsRequest { Id = "id" });
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

**request:** `RetrieveNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">DeleteAsync</a>(DeleteNotificationsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a notification.
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
await client.Notifications.DeleteAsync(new DeleteNotificationsRequest { Id = "id" });
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

**request:** `DeleteNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Notifications.<a href="/src/ForuMsApi/Notifications/NotificationsClient.cs">UpdateAsync</a>(UpdateNotificationsRequest { ... }) -> UpdateNotificationsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing notification. Only provided fields will be modified.
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
await client.Notifications.UpdateAsync(new UpdateNotificationsRequest { Id = "id" });
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

**request:** `UpdateNotificationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">ListAsync</a>(ListWebhooksRequest { ... }) -> WebhookListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of webhooks. Use cursor for pagination.

**Requires feature: webhooks**
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
await client.Webhooks.ListAsync(new ListWebhooksRequest());
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

**request:** `ListWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">CreateAsync</a>(CreateWebhooksRequest { ... }) -> WebhookResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new webhook.

**Requires feature: webhooks**
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
await client.Webhooks.CreateAsync(
    new CreateWebhooksRequest
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

**request:** `CreateWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">RetrieveAsync</a>(RetrieveWebhooksRequest { ... }) -> WebhookResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a webhook by ID or slug (if supported).

**Requires feature: webhooks**
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
await client.Webhooks.RetrieveAsync(new RetrieveWebhooksRequest { Id = "id" });
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

**request:** `RetrieveWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">DeleteAsync</a>(DeleteWebhooksRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete a webhook.

**Requires feature: webhooks**
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
await client.Webhooks.DeleteAsync(new DeleteWebhooksRequest { Id = "id" });
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

**request:** `DeleteWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">UpdateAsync</a>(UpdateWebhooksRequest { ... }) -> UpdateWebhooksResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing webhook. Only provided fields will be modified.

**Requires feature: webhooks**
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
await client.Webhooks.UpdateAsync(new UpdateWebhooksRequest { Id = "id" });
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

**request:** `UpdateWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">ListDeliveriesAsync</a>(ListDeliveriesWebhooksRequest { ... }) -> WebhookDeliveryListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of deliveries for Webhook.

**Requires feature: webhooks**
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
await client.Webhooks.ListDeliveriesAsync(new ListDeliveriesWebhooksRequest { Id = "id" });
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

**request:** `ListDeliveriesWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">RetrieveDeliveryAsync</a>(RetrieveDeliveryWebhooksRequest { ... }) -> RetrieveDeliveryWebhooksResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.RetrieveDeliveryAsync(
    new RetrieveDeliveryWebhooksRequest { Id = "id", SubId = "subId" }
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

**request:** `RetrieveDeliveryWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/ForuMsApi/Webhooks/WebhooksClient.cs">DeleteDeliveryAsync</a>(DeleteDeliveryWebhooksRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeleteDeliveryAsync(
    new DeleteDeliveryWebhooksRequest { Id = "id", SubId = "subId" }
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

**request:** `DeleteDeliveryWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Integrations
<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">ListAsync</a>(ListIntegrationsRequest { ... }) -> IntegrationListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of integrations. Use cursor for pagination.

**Requires feature: integrations**
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
await client.Integrations.ListAsync(new ListIntegrationsRequest());
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

**request:** `ListIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">CreateAsync</a>(CreateIntegrationsRequest { ... }) -> IntegrationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an new integration.

**Requires feature: integrations**
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
await client.Integrations.CreateAsync(
    new CreateIntegrationsRequest
    {
        Type = "type",
        Name = "name",
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

**request:** `CreateIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">RetrieveAsync</a>(RetrieveIntegrationsRequest { ... }) -> IntegrationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve an integration by ID or slug (if supported).

**Requires feature: integrations**
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
await client.Integrations.RetrieveAsync(new RetrieveIntegrationsRequest { Id = "id" });
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

**request:** `RetrieveIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">DeleteAsync</a>(DeleteIntegrationsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete an integration.

**Requires feature: integrations**
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
await client.Integrations.DeleteAsync(new DeleteIntegrationsRequest { Id = "id" });
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

**request:** `DeleteIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Integrations.<a href="/src/ForuMsApi/Integrations/IntegrationsClient.cs">UpdateAsync</a>(UpdateIntegrationsRequest { ... }) -> UpdateIntegrationsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing integration. Only provided fields will be modified.

**Requires feature: integrations**
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
await client.Integrations.UpdateAsync(new UpdateIntegrationsRequest { Id = "id" });
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

**request:** `UpdateIntegrationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SSOs
<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">ListAsync</a>(ListSsOsRequest { ... }) -> SsoListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a paginated list of ssos. Use cursor for pagination.

**Requires feature: sso**
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
await client.SsOs.ListAsync(new ListSsOsRequest());
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

**request:** `ListSsOsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">CreateAsync</a>(CreateSsOsRequest { ... }) -> SsoResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an new sso.

**Requires feature: sso**
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
await client.SsOs.CreateAsync(
    new CreateSsOsRequest
    {
        Provider = CreateSsOsRequestProvider.Okta,
        Domain = "domain",
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

**request:** `CreateSsOsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">RetrieveAsync</a>(RetrieveSsOsRequest { ... }) -> SsoResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve an sso by ID or slug (if supported).

**Requires feature: sso**
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
await client.SsOs.RetrieveAsync(new RetrieveSsOsRequest { Id = "id" });
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

**request:** `RetrieveSsOsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">DeleteAsync</a>(DeleteSsOsRequest { ... }) -> SuccessResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete an sso.

**Requires feature: sso**
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
await client.SsOs.DeleteAsync(new DeleteSsOsRequest { Id = "id" });
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

**request:** `DeleteSsOsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.SsOs.<a href="/src/ForuMsApi/SsOs/SsOsClient.cs">UpdateAsync</a>(UpdateSsOsRequest { ... }) -> UpdateSsOsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing sso. Only provided fields will be modified.

**Requires feature: sso**
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
await client.SsOs.UpdateAsync(new UpdateSsOsRequest { Id = "id" });
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

**request:** `UpdateSsOsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Provisioning
<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ListAsync</a>(ListProvisioningRequest { ... }) -> ListProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all instances owned by the authenticated user. Use the `handle` query parameter to get a single instance with its API key.
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
await client.Provisioning.ListAsync(
    new ListProvisioningRequest { ProvisioningKey = "x-provisioning-key" }
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

**request:** `ListProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">CreateAsync</a>(CreateInstance { ... }) -> CreateProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new forum instance. Returns the instance details including the API key for accessing the forum API.
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
await client.Provisioning.CreateAsync(
    new CreateInstance
    {
        ProvisioningKey = "x-provisioning-key",
        Name = "name",
        Handle = "handle",
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

**request:** `CreateInstance` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">UpdateAsync</a>(UpdateInstance { ... }) -> UpdateProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an instance's name or handle. The `handle` field identifies which instance to update.
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
await client.Provisioning.UpdateAsync(
    new UpdateInstance { ProvisioningKey = "x-provisioning-key", Handle = "handle" }
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

**request:** `UpdateInstance` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">DeleteAsync</a>(DeleteInstance { ... }) -> DeleteProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete an instance. This action cannot be undone.
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
await client.Provisioning.DeleteAsync(
    new DeleteInstance { ProvisioningKey = "x-provisioning-key", Handle = "handle" }
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

**request:** `DeleteInstance` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">GetBillingAsync</a>(GetBillingProvisioningRequest { ... }) -> GetBillingProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve billing and subscription information for an instance.
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
await client.Provisioning.GetBillingAsync(
    new GetBillingProvisioningRequest { Handle = "handle", ProvisioningKey = "x-provisioning-key" }
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

**request:** `GetBillingProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ChangePlanAsync</a>(UpgradeInstance { ... }) -> ChangePlanProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Change an instance's subscription plan. Returns a checkout URL for upgrades or a billing portal URL for downgrades.
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
await client.Provisioning.ChangePlanAsync(
    new UpgradeInstance
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        Plan = UpgradeInstancePlan.Free,
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

**request:** `UpgradeInstance` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">RegenerateApiKeyAsync</a>(RegenerateApiKeyProvisioningRequest { ... }) -> RegenerateApiKeyProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Generate a new API key for the instance. The old key will be invalidated.
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
await client.Provisioning.RegenerateApiKeyAsync(
    new RegenerateApiKeyProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
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

**request:** `RegenerateApiKeyProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">GetUsageAsync</a>(GetUsageProvisioningRequest { ... }) -> GetUsageProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve usage statistics for an instance including API requests, storage, and content counts.
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
await client.Provisioning.GetUsageAsync(
    new GetUsageProvisioningRequest { Handle = "handle", ProvisioningKey = "x-provisioning-key" }
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

**request:** `GetUsageProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ListTeamAsync</a>(ListTeamProvisioningRequest { ... }) -> ListTeamProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all team members for an instance.
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
await client.Provisioning.ListTeamAsync(
    new ListTeamProvisioningRequest { Handle = "handle", ProvisioningKey = "x-provisioning-key" }
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

**request:** `ListTeamProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">InviteTeamAsync</a>(InviteTeamProvisioningRequest { ... }) -> InviteTeamProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Invite new team members to an instance.
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
await client.Provisioning.InviteTeamAsync(
    new InviteTeamProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        Members = new List<InviteTeamProvisioningRequestMembersItem>()
        {
            new InviteTeamProvisioningRequestMembersItem { Email = "email" },
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

**request:** `InviteTeamProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">RemoveTeamMemberAsync</a>(RemoveTeamMemberProvisioningRequest { ... }) -> RemoveTeamMemberProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a team member from an instance.
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
await client.Provisioning.RemoveTeamMemberAsync(
    new RemoveTeamMemberProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        Email = "email",
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

**request:** `RemoveTeamMemberProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ListDomainsAsync</a>(ListDomainsProvisioningRequest { ... }) -> ListDomainsProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all custom domains for an instance.
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
await client.Provisioning.ListDomainsAsync(
    new ListDomainsProvisioningRequest { Handle = "handle", ProvisioningKey = "x-provisioning-key" }
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

**request:** `ListDomainsProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">AddDomainAsync</a>(AddDomainProvisioningRequest { ... }) -> AddDomainProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a custom domain to an instance.
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
await client.Provisioning.AddDomainAsync(
    new AddDomainProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        Name = "name",
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

**request:** `AddDomainProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">RemoveDomainAsync</a>(RemoveDomainProvisioningRequest { ... }) -> RemoveDomainProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove a custom domain from an instance.
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
await client.Provisioning.RemoveDomainAsync(
    new RemoveDomainProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        Name = "name",
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

**request:** `RemoveDomainProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ExportDataAsync</a>(ExportDataProvisioningRequest { ... }) -> ExportDataProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Export all data from an instance including threads, posts, users, tags, etc.
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
await client.Provisioning.ExportDataAsync(
    new ExportDataProvisioningRequest { ProvisioningKey = "x-provisioning-key", Handle = "handle" }
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

**request:** `ExportDataProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">ListWebhooksAsync</a>(ListWebhooksProvisioningRequest { ... }) -> ListWebhooksProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all webhooks configured for an instance.
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
await client.Provisioning.ListWebhooksAsync(
    new ListWebhooksProvisioningRequest
    {
        Handle = "handle",
        ProvisioningKey = "x-provisioning-key",
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

**request:** `ListWebhooksProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">CreateWebhookAsync</a>(CreateWebhookProvisioningRequest { ... }) -> CreateWebhookProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new webhook for an instance.
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
await client.Provisioning.CreateWebhookAsync(
    new CreateWebhookProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
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

**request:** `CreateWebhookProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">UpdateWebhookAsync</a>(UpdateWebhookProvisioningRequest { ... }) -> UpdateWebhookProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing webhook.
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
await client.Provisioning.UpdateWebhookAsync(
    new UpdateWebhookProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        WebhookId = "webhookId",
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

**request:** `UpdateWebhookProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">DeleteWebhookAsync</a>(DeleteWebhookProvisioningRequest { ... }) -> DeleteWebhookProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a webhook from an instance.
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
await client.Provisioning.DeleteWebhookAsync(
    new DeleteWebhookProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        WebhookId = "webhookId",
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

**request:** `DeleteWebhookProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">GetOwnershipAsync</a>(GetOwnershipProvisioningRequest { ... }) -> GetOwnershipProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve owner and creator information for an instance.
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
await client.Provisioning.GetOwnershipAsync(
    new GetOwnershipProvisioningRequest
    {
        Handle = "handle",
        ProvisioningKey = "x-provisioning-key",
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

**request:** `GetOwnershipProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">TransferOwnershipAsync</a>(TransferOwnershipProvisioningRequest { ... }) -> TransferOwnershipProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Transfer instance ownership to another user. Only the current owner can transfer ownership.
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
await client.Provisioning.TransferOwnershipAsync(
    new TransferOwnershipProvisioningRequest
    {
        ProvisioningKey = "x-provisioning-key",
        Handle = "handle",
        NewOwnerEmail = "newOwnerEmail",
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

**request:** `TransferOwnershipProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">RegisterAsync</a>(RegisterProvisioningRequest { ... }) -> RegisterProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new account and receive a provisioning key for API access. Use this key to create and manage instances.
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
await client.Provisioning.RegisterAsync(
    new RegisterProvisioningRequest { Email = "email", Password = "password" }
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

**request:** `RegisterProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Provisioning.<a href="/src/ForuMsApi/Provisioning/ProvisioningClient.cs">LoginAsync</a>(LoginProvisioningRequest { ... }) -> LoginProvisioningResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Login with email and password to retrieve your provisioning key.
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
await client.Provisioning.LoginAsync(
    new LoginProvisioningRequest { Email = "email", Password = "password" }
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

**request:** `LoginProvisioningRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
