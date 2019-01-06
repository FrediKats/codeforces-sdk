<a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-2.0-green.svg"></a>
<a href="https://docs.microsoft.com/en-us/dotnet/core/"><img src="https://img.shields.io/badge/.NET%20Core-2.2-green.svg"></a>
# CodeforcesApiWrapper

CodeforcesApiWrapper - [Codeforces API](https://codeforces.com/api/help) implementation in .NET.

## Getting Started
### Used technologies

- .NET Standard 2.0
- .NET Core 2.2 (Unit-tests)
- MSTest (Unit-tests)
- [Refit 4.6.58](https://github.com/reactiveui/refit)
- [HtmlAgilityPack 1.8.11](https://github.com/zzzprojects/html-agility-pack)

### CodeforcesDocsParser

This project contains code for parsing https://codeforces.com/api/help/objects and generating models on C# language. Probably, it's easy enough to implement generating to other language. Generated classes you can find here: [CodeforcesApiWrapper/Types](CodeforcesApiWrapper/Types).


### CodeforcesApiWrapper

Contains implementation of https://codeforces.com/api/help/methods. You can user class `Codeforces` for access to methods:
```C#
var codeforces = new Codeforces();
ResponseContainer<List<Comment>> response = codeforces.BlogEntity.Comments(79).Result;
```
Each method call returns a JSON-object (`ResponseContainer<T>`) with three possible fields: status, comment and result.

- Status is either "OK" or "FAILED".
- If status is "FAILED" then comment contains the reason why the request failed. If status is "OK", then there is no comment.
- If status is "OK" then result contains method-dependent JSON-element which will be described for each method separately. If status is "FAILED", then there is no result.

## TODO:

- [ ] Fix some problems with API docs
- [x] Add missing method with argument list (like `user.info`)
- [ ] Add methods with access token
- [ ] Implement other language code-generationg
- [ ] Remove "dirty hacks from code"
- [ ] Build as nuget package and add to marketplace
- [ ] Return full data if no handles from arguments wasn't found. Seem like bug