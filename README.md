# ForuMs C# Library

![](https://foru.ms/images/cover.png)

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-Built%20with%20Fern-brightgreen)](https://buildwithfern.com?utm_source=github&utm_medium=github&utm_campaign=readme&utm_source=https%3A%2F%2Fgithub.com%2Fforu-ms%2Fcsharp-sdk)
[![nuget shield](https://img.shields.io/nuget/v/ForuMsApi)](https://nuget.org/packages/ForuMsApi)

The ForuMs C# library provides convenient access to the ForuMs APIs from C#.

## Table of Contents

- [Documentation](#documentation)
- [Requirements](#requirements)
- [Installation](#installation)
- [Reference](#reference)
- [Usage](#usage)
- [Exception Handling](#exception-handling)
- [Advanced](#advanced)
  - [Retries](#retries)
  - [Timeouts](#timeouts)
  - [Forward Compatible Enums](#forward-compatible-enums)
- [Contributing](#contributing)

## Documentation

API reference documentation is available [here](https://foru.ms/docs/api-reference).

## Requirements

This SDK requires:

## Installation

```sh
dotnet add package ForuMsApi
```

## Reference

A full reference for this library is available [here](https://github.com/foru-ms/csharp-sdk/blob/HEAD/./reference.md).

## Usage

Instantiate and use the client with the following:

```csharp
using ForuMsApi;

var client = new ForumClient("API_KEY");
await client.Auth.RegisterAsync(
    new RegisterAuthRequest
    {
        Username = "username",
        Email = "email",
        Password = "password",
    }
);
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), a subclass of the following error
will be thrown.

```csharp
using ForuMsApi;

try {
    var response = await client.Auth.RegisterAsync(...);
} catch (ForumClientApiException e) {
    System.Console.WriteLine(e.Body);
    System.Console.WriteLine(e.StatusCode);
}
```

## Advanced

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retryable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retryable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `MaxRetries` request option to configure this behavior.

```csharp
var response = await client.Auth.RegisterAsync(
    ...,
    new RequestOptions {
        MaxRetries: 0 // Override MaxRetries at the request level
    }
);
```

### Timeouts

The SDK defaults to a 30 second timeout. Use the `Timeout` option to configure this behavior.

```csharp
var response = await client.Auth.RegisterAsync(
    ...,
    new RequestOptions {
        Timeout: TimeSpan.FromSeconds(3) // Override timeout to 3s
    }
);
```

### Forward Compatible Enums

This SDK uses forward-compatible enums that can handle unknown values gracefully.

```csharp
using ForuMsApi;

// Using a built-in value
var searchSearchResponseDataItemsItemType = SearchSearchResponseDataItemsItemType.Thread;

// Using a custom value
var customSearchSearchResponseDataItemsItemType = SearchSearchResponseDataItemsItemType.FromCustom("custom-value");

// Using in a switch statement
switch (searchSearchResponseDataItemsItemType.Value)
{
    case SearchSearchResponseDataItemsItemType.Values.Thread:
        Console.WriteLine("Thread");
        break;
    default:
        Console.WriteLine($"Unknown value: {searchSearchResponseDataItemsItemType.Value}");
        break;
}

// Explicit casting
string searchSearchResponseDataItemsItemTypeString = (string)SearchSearchResponseDataItemsItemType.Thread;
SearchSearchResponseDataItemsItemType searchSearchResponseDataItemsItemTypeFromString = (SearchSearchResponseDataItemsItemType)"thread";
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!