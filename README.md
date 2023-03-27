# Lanyard.NET [![Build artifact][build-src]][build-href] [![Codacy Badge][codacy-src]][codacy-href]

[![NuGet][nuget-src]][nuget-href]

.NET library for [Lanyard API](https://github.com/Phineas/lanyard)

## Usage

* `<UserID>` - Discord user ID
* `<APIKey>` - Lanyard KV API key

### LanyardClient

Class for getting user presence

```C#
using var Client = new LanyardClient();
var Response = await Client.GetPresence(<UserID>);
var Presence = Response.Data;
```

### KVClient

Class for managing KV store

```C#
using var KV = new KVClient(<UserID>, <APIKey>);
// Set key
await KV.SetKey(<Key>, <Value>);
// Set multiple keys
var Keys = new Dictionary<string, string> {
    { <Key>, <Value> },
    { <Key>, <Value> }
};
await KV.SetKeys(Keys);
// Delete key
await KV.DeleteKey(<Key>);
// Get presence
var Response = await Client.GetPresence();
var Presence = Response.Data;
```

## Lanyard.WF

WinForms application for testing library

<!-- Badges -->
[build-src]: https://img.shields.io/github/actions/workflow/status/Virenbar/lanyard-net/build-artifact.yml?label=Build&logo=github
[build-href]: https://github.com/Virenbar/lanyard-net/actions/workflows/build-artifact.yml

[codacy-src]: https://app.codacy.com/project/badge/Grade/bfe34ced3e784389b5235fdaf193e038
[codacy-href]: https://www.codacy.com/gh/Virenbar/lanyard-net/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Virenbar/lanyard-net&amp;utm_campaign=Badge_Grade

[nuget-src]: https://img.shields.io/nuget/v/Virenbar.Lanyard?label=Lanyard&logo=nuget&style=for-the-badge
[nuget-href]: https://www.nuget.org/packages/Virenbar.Lanyard/
