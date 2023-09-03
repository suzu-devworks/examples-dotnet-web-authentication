# Configuration

## The way to the present

```shell
git clone https://github.com/suzu-devworks/examples-dotnet-web-auth.git
cd examples-dotnet-web-auth

## run in Dev Container.

dotnet new sln -o .

#dotnet nuget update source github --username suzu-devworks --password "{parsonal access token}" --store-password-in-clear-text

## Examples.Web.Authentication

## Examples.Web.Authentication.Basic
dotnet new webapi -o src/Examples.Web.Authentication.Basic
cd src/Examples.Web.Authentication.Basic
cd ../../
dotnet sln add src/Examples.Web.Authentication.Basic/

dotnet build

# Update outdated package
dotnet list package --outdated

# Tools
dotnet new tool-manifest

```
