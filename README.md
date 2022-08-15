# DotNet Templates

[![Build status](https://bofaz.visualstudio.com)

Install (see below for more information): `dotnet new -i AxosBank.DotNetTemplates --nuget-source https://bofaz.pkgs.visualstudio.com`  

**N O T E :** *The templates now support both Docker and VS Code!  See below for more details.*

* `axosbank-package`: Creates a .NET Standard class library with MinVer and includes a YAML
CI build definition that publishes a NuGet package to the Axos Bank NuGet feed.
Described in more detail further down

## Installation

Installation of the templates is simple, but you need the .NET Core SDK installed
to use them.  That's included with Visual Studio 2019 or you
can get it standalone from here (you want the **SDKs** for your platform):

[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

**N O T E:** If you are installing the SDK, you probably should trust the DEV HTTPS certificate to enable HTTPS development:

```bash
dotnet dev-certs https --trust
```

Then to install the templates:

`dotnet new -i AxosBank.DotNetTemplates --nuget-source https://bofaz.pkgs.visualstudio.com/`

To confirm the installation, run:

```bash
donet new --list
```

You should see some Axos Bank templates in the listing of installed templates.


### Uninstalling / Resetting

If you'd like to uninstall these templates, it's pretty simple:

`dotnet new -u AxosBank.DotNetTemplates`

If you need to set back your `dotnet new` list to "factory defaults", use this command:

`dotnet new --debug:reinit`

## Template(s)

### **dotnet new rp-package**

This template creates a .NET Standard class library that will be published as a NuGet package to the Axos Bank
 Nuget feed. To make debugging easier for consumers of the package, the project is configured to use [Source Link](https://github.com/dotnet/sourcelink/blob/main/README.md#source-link).

`dotnet new axosbank-package -o <projname>`

Check out the Readme in that folder (or your generated project) for more details about this project.

## Things to try

Check the `Instructions.md` file for some simple things to try and more detailed guidance on introducing
your own logic into the projects / applications.

## Todos in the projects

When you create a project there are a few steps you need to follow.  They are documented with the following syntax:

`//TODO: take this action`

So if you open a "Task View" in Visual Studio you should be able to see the short list of things you probably need to follow-up on to really get your project set up correctly.

## Contributing

If you'd like to add more templates or update the existing ones:

* clone the repo
* branch it
* make your changes, update the semantic version of the `.nuspec` file, and update the readme.md and/or releasenotes.md documents
* commit and publish your new branch
* submit a pull request

Upon completion of the pull request, a new version of the package will be published.
