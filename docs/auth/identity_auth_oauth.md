# External OAuth authentication providers

## References

- [External OAuth authentication providers](https://learn.microsoft.com/ja-jp/aspnet/core/security/authentication/social/other-logins?view=aspnetcore-6.0)
- [AspNet.Security.OAuth.Providers](https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers)


## Github auth provider

### Create OAuth 2.0 Client ID and secret

- [Register a new OAuth application - Github](https://github.com/settings/applications/new/)

### Add packages

```shell
### Github
dotnet add package AspNet.Security.OAuth.GitHub
#dotnet add package OctoKit
```

### Store the Google client ID and secret

```shell
### Github
dotnet user-secrets set "Authentication:Github:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Github:ClientSecret" "<client-secret>"

dotnet user-secrets list
```

### Modofy Codes

```diff
@@ -10,6 +10,7 @@
         options.ConnectionString = builder.Configuration.GetConnectionString("IdentityDataContextConnection")
+    .AddGitHub(githubOptions =>
+    {
+        githubOptions.ClientId = builder.Configuration["Authentication:Github:ClientId"];
+        githubOptions.ClientSecret = builder.Configuration["Authentication:Github:ClientSecret"];
+        // https://docs.github.com/en/developers/apps/building-oauth-apps/scopes-for-oauth-apps
+        githubOptions.Scope.Add("user:email");
     });
```
