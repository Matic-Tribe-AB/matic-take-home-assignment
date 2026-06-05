var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();
app.UseCors();

// -------------------------------------------------------
// TODO: Implement your data store here
// (in-memory list, JSON file, or SQLite — your choice)
// -------------------------------------------------------

// -------------------------------------------------------
// TODO: Implement these routes
//
// GET    /api/posts        → return all posts, newest first
// POST   /api/posts        → create a post { title, body }
// PATCH  /api/posts/{id}   → toggle read status
// DELETE /api/posts/{id}   → delete a post
// -------------------------------------------------------

app.MapGet("/api/health", () => Results.Ok(new { status = "ok" }));

var port = Environment.GetEnvironmentVariable("PORT") ?? "3001";
app.Run($"http://localhost:{port}");

// Expose Program type for integration testing
public partial class Program { }
