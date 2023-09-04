# ASP.NET Core Identity external provider authentication

Enables users to sign in using OAuth 2.0 with credentials from external authentication providers.

## References

- [Facebook, Google, and external provider authentication in ASP.NET Core](https://learn.microsoft.com/ja-jp/aspnet/core/security/authentication/social/?view=aspnetcore-6.0)

<!-- ----- -->

## Configuration

### Create OAuth 2.0 Client ID and secret

**Google**

- [Google external login setup in ASP.NET Core](https://learn.microsoft.com/ja-jp/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-6.0)
- [Google Cloud Pretform](https://console.cloud.google.com/)

**Microsoft**

- [Microsoft Account external login setup with ASP.NET Core](https://learn.microsoft.com/ja-jp/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-6.0)
- [Azure portal - App registrations](https://go.microsoft.com/fwlink/?linkid=2083908)

### Add packages

```shell
dotnet add package Microsoft.AspNetCore.Authentication.Google
dotnet add package Microsoft.AspNetCore.Authentication.MicrosoftAccount

```

### Store the Google client ID and secret

```shell
### Google
dotnet user-secrets set "Authentication:Google:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Google:ClientSecret" "<client-secret>"

### MicrosoftAccount
dotnet user-secrets set "Authentication:Microsoft:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Microsoft:ClientSecret" "<client-secret>"

dotnet user-secrets list
```

### Modofy Codes

```diff
        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<IdentityDataContext>();

+        services.AddAuthentication().AddGoogle(googleOptions =>
+        {
+            googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
+            googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
+        });
+
+        services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
+        {
+            microsoftOptions.ClientId = configuration["Authentication:Microsoft:ClientId"];
+            microsoftOptions.ClientSecret = configuration["Authentication:Microsoft:ClientSecret"];
+        });
```
