using System.Security.Claims;
using Bunit;
using CSE325_GROUP.Components.Pages;
using CSE325_GROUP.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CSE325_GROUP.Tests;

public sealed class GameDetailsTests : BunitContext
{
    [Fact]
    public async Task MissingGameId_RendersNotFoundAlert()
    {
        await using var connection = new SqliteConnection("Data Source=:memory:");
        await connection.OpenAsync();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlite(connection)
            .Options;
        await using var db = new ApplicationDbContext(options);
        await db.Database.EnsureCreatedAsync();

        Services.AddSingleton(db);
        Services.AddSingleton<AuthenticationStateProvider>(new AnonymousAuthenticationStateProvider());

        var cut = Render<GameDetails>(parameters => parameters
            .Add(component => component.Id, "999999"));

        await cut.WaitForAssertionAsync(() =>
        {
            Assert.Equal("Game not found.", cut.Find(".alert.alert-warning[role='alert']").TextContent.Trim());
        });
    }

    private sealed class AnonymousAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync() =>
            Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
    }
}