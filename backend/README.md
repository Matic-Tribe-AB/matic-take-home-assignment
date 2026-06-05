# PostFeed Backend

ASP.NET Core Web API starter. See the root README for the full brief.

## Setup

```bash
dotnet run --project PostFeed.Api   # run the API
dotnet test                         # run tests
```

Runs on **http://localhost:3001** by default (set the `PORT` environment variable to override).

## Notes

- `PostFeed.Api/Program.cs` is the entry point — implement your routes here or split into separate files
- Persistence is your choice: in-memory list, JSON file, or SQLite
- Add any NuGet packages you need via `dotnet add package`
- `PostFeed.Tests/HealthTests.cs` shows how to write integration tests using `WebApplicationFactory`
