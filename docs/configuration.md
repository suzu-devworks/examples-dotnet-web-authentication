# Configuration

## The way to the present

```shell
git clone https://github.com/suzu-devworks/examples-dotnet-web-authentication.git
cd examples-dotnet-web-authentication

## run in Dev Container.

dotnet new sln -o .

#dotnet nuget update source github --username suzu-devworks --password "{parsonal access token}" --store-password-in-clear-text

## Examples.Web.Authentication

## Examples.Web.Authentication.Identity
dotnet new mvc -o src/Examples.Web.Authentication.Identity
dotnet sln add src/Examples.Web.Authentication.Identity/
cd src/Examples.Web.Authentication.Identity

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.*
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.*
dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0.*
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet aspnet-codegenerator identity --useSqLite --useDefaultUI
dotnet ef migrations add CreateIdentitySchema
dotnet ef database update

dotnet add package Microsoft.AspNetCore.Authentication.Google --version 6.0.*
dotnet add package Microsoft.AspNetCore.Authentication.MicrosoftAccount --version 6.0.*
dotnet add package AspNet.Security.OAuth.GitHub --version 6.0.*

cd ../../


## Examples.Web.Authentication.Basic
dotnet new webapp -o src/Examples.Web.Authentication.Basic
dotnet sln add src/Examples.Web.Authentication.Basic/
cd src/Examples.Web.Authentication.Basic
cd ../../

dotnet build

# Update outdated package
dotnet list package --outdated

# Tools
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet tool install dotnet-aspnet-codegenerator --version 6.0.*
dotnet tool restore

```
