# ASP.NET Core Identity external provider authentication

Enables users to sign in using OAuth 2.0 with credentials from external authentication providers.

<!-- ----- -->

## References

- [ASP.NET Core での Google 外部ログインのセットアップ - Microsoft Docs](https://learn.microsoft.com/ja-jp/aspnet/core/security/authentication/social/?view=aspnetcore-6.0)

<!-- ----- -->

## Create OAuth 2.0 Client ID and secret

- [Google Cloud Pretform](https://console.cloud.google.com/)
- [Azure portal - App registrations](https://go.microsoft.com/fwlink/?linkid=2083908)

<!-- ----- -->

## Configuration

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
