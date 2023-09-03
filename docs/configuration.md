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
cd src/Examples.Web.Authentication.Identity
cd ../../
dotnet sln add src/Examples.Web.Authentication.Identity/

## Examples.Web.Authentication.Basic
dotnet new webapp -o src/Examples.Web.Authentication.Basic
cd src/Examples.Web.Authentication.Basic
cd ../../
dotnet sln add src/Examples.Web.Authentication.Basic/

dotnet build

# Update outdated package
dotnet list package --outdated

# Tools
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet tool install dotnet-aspnet-codegenerator --version 6.0.*
dotnet tool restore

```
