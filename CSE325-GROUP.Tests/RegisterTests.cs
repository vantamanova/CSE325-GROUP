using System.Security.Claims;
using Bunit;
using CSE325_GROUP.Components.Account.Pages;
using CSE325_GROUP.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace CSE325_GROUP.Tests;

public sealed class RegisterTests : BunitContext
{
    [Fact]
    public async Task FailedRegistration_RendersIdentityErrorInStatusMessage()
    {
        var store = new InMemoryUserStore();
        var userManager = new TestUserManager(store, registrationSucceeds: false);
        var signInManager = CreateSignInManager(userManager);
        var emailSender = new NoOpEmailSender();

        Services.AddSingleton<IUserStore<ApplicationUser>>(store);
        Services.AddSingleton<UserManager<ApplicationUser>>(userManager);
        Services.AddSingleton(signInManager);
        Services.AddSingleton<IEmailSender<ApplicationUser>>(emailSender);

        var redirectManagerType = typeof(Register).Assembly.GetType(
            "CSE325_GROUP.Components.Account.IdentityRedirectManager",
            throwOnError: true)!;
        Services.AddSingleton(redirectManagerType, serviceProvider =>
            Activator.CreateInstance(
                redirectManagerType,
                serviceProvider.GetRequiredService<NavigationManager>())!);

        var cut = Render<CascadingValue<HttpContext>>(parameters => parameters
            .Add(parameter => parameter.Value, new DefaultHttpContext())
            .AddChildContent<Register>());

        cut.Find("[id='Input.Email']").Change("duplicate@example.com");
        cut.Find("[id='Input.Password']").Change("A-valid-password1!");
        cut.Find("[id='Input.ConfirmPassword']").Change("A-valid-password1!");

        await cut.InvokeAsync(() => cut.Find("form").Submit());

        Assert.Equal(
            "Error: That email address is already registered.",
            cut.Find(".alert.alert-danger[role='alert']").TextContent.Trim());
    }

    [Fact]
    public async Task SuccessfulRegistration_DoesNotRenderErrorStatusMessage()
    {
        var store = new InMemoryUserStore();
        var userManager = new TestUserManager(store, registrationSucceeds: true);
        var signInManager = CreateSignInManager(userManager);

        Services.AddSingleton<IUserStore<ApplicationUser>>(store);
        Services.AddSingleton<UserManager<ApplicationUser>>(userManager);
        Services.AddSingleton(signInManager);
        Services.AddSingleton<IEmailSender<ApplicationUser>>(new NoOpEmailSender());

        AddRedirectManager();

        var cut = Render<CascadingValue<HttpContext>>(parameters => parameters
            .Add(parameter => parameter.Value, new DefaultHttpContext())
            .AddChildContent<Register>());

        cut.Find("[id='Input.Email']").Change("new-user@example.com");
        cut.Find("[id='Input.Password']").Change("A-valid-password1!");
        cut.Find("[id='Input.ConfirmPassword']").Change("A-valid-password1!");

        await cut.InvokeAsync(() => cut.Find("form").Submit());

        Assert.Empty(cut.FindAll(".alert.alert-danger[role='alert']"));
        Assert.Contains("Account/RegisterConfirmation", Services
            .GetRequiredService<NavigationManager>().Uri);
    }

    private void AddRedirectManager()
    {
        var redirectManagerType = typeof(Register).Assembly.GetType(
            "CSE325_GROUP.Components.Account.IdentityRedirectManager",
            throwOnError: true)!;
        Services.AddSingleton(redirectManagerType, serviceProvider =>
            Activator.CreateInstance(
                redirectManagerType,
                serviceProvider.GetRequiredService<NavigationManager>())!);
    }

    private static SignInManager<ApplicationUser> CreateSignInManager(
        UserManager<ApplicationUser> userManager)
    {
        var options = Options.Create(new IdentityOptions());
        return new SignInManager<ApplicationUser>(
            userManager,
            new HttpContextAccessor(),
            new UserClaimsPrincipalFactory<ApplicationUser>(userManager, options),
            options,
            NullLogger<SignInManager<ApplicationUser>>.Instance,
            new AuthenticationSchemeProvider(Options.Create(new AuthenticationOptions())),
            new DefaultUserConfirmation<ApplicationUser>());
    }

    private sealed class TestUserManager : UserManager<ApplicationUser>
    {
        private readonly bool registrationSucceeds;

        public TestUserManager(IUserStore<ApplicationUser> store, bool registrationSucceeds)
            : base(
                store,
                Microsoft.Extensions.Options.Options.Create(new IdentityOptions
                {
                    SignIn = { RequireConfirmedAccount = true }
                }),
                new PasswordHasher<ApplicationUser>(),
                [],
                [],
                new UpperInvariantLookupNormalizer(),
                new IdentityErrorDescriber(),
                new ServiceCollection().BuildServiceProvider(),
                NullLogger<UserManager<ApplicationUser>>.Instance)
        {
            this.registrationSucceeds = registrationSucceeds;
        }

        public override Task<IdentityResult> CreateAsync(ApplicationUser user, string password)
        {
            return Task.FromResult(registrationSucceeds
                ? IdentityResult.Success
                : IdentityResult.Failed(new IdentityError
                {
                    Description = "That email address is already registered."
                }));
        }

        public override Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user) =>
            Task.FromResult("test-confirmation-token");
    }

    private sealed class InMemoryUserStore : IUserEmailStore<ApplicationUser>
    {
        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.Id);

        public Task<string?> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.UserName);

        public Task SetUserNameAsync(ApplicationUser user, string? userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task<string?> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.NormalizedUserName);

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string? normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(IdentityResult.Success);

        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(IdentityResult.Success);

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(IdentityResult.Success);

        public Task<ApplicationUser?> FindByIdAsync(string userId, CancellationToken cancellationToken) =>
            Task.FromResult<ApplicationUser?>(null);

        public Task<ApplicationUser?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken) =>
            Task.FromResult<ApplicationUser?>(null);

        public Task SetEmailAsync(ApplicationUser user, string? email, CancellationToken cancellationToken)
        {
            user.Email = email;
            return Task.CompletedTask;
        }

        public Task<string?> GetEmailAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.Email);

        public Task<bool> GetEmailConfirmedAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.EmailConfirmed);

        public Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed, CancellationToken cancellationToken)
        {
            user.EmailConfirmed = confirmed;
            return Task.CompletedTask;
        }

        public Task<ApplicationUser?> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken) =>
            Task.FromResult<ApplicationUser?>(null);

        public Task<string?> GetNormalizedEmailAsync(ApplicationUser user, CancellationToken cancellationToken) =>
            Task.FromResult(user.NormalizedEmail);

        public Task SetNormalizedEmailAsync(ApplicationUser user, string? normalizedEmail, CancellationToken cancellationToken)
        {
            user.NormalizedEmail = normalizedEmail;
            return Task.CompletedTask;
        }

        public void Dispose()
        {
        }
    }

    private sealed class NoOpEmailSender : IEmailSender<ApplicationUser>
    {
        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            Task.CompletedTask;

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            Task.CompletedTask;

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            Task.CompletedTask;
    }
}