# Antshares Core

This repository is a container for the Antshares Wallet application ( UI ) as well as the Daemon, which can be used as a wallet and runs an RPC service.

## Antshares UI

The UI Application works on the following platforms:

| Platform      | Wallet         |
| ------------- |:-------------: |
| Windows       | ✅             |
| Linux (All)   | ❌             |
| OSX           | ❌             |

Development is in process for a cross-platform GUI wallet application.

## Antshares Daemon

The following instructions can get you building the project on your preferred platform and running it.


# Windows Instructions

Open the project with Visual studio, and run it!


# OSX Instructions

### Install dependencies
To Run the daemon on OSX, you will need to install LevelDB.  If you are adventurous, you can build from source.  Otherwise, there is a package for Homebrew:

```
brew install leveldb
```

You will also need to install .NET core framework from microsoft.  You can download that here:

https://www.microsoft.com/net/core#macos

After installing, you should be able to do the following from your terminal without error:

```
dotnet
```


### Extra dependencies for compiling
If you would like to compile the project with mono instead of .NET Core, you will also need the most recent version of MonoFramework.  You can search the internet to download/install from here: http://www.mono-project.com/download/.  You can also use Homebrew to install it with `brew install mono`

### Get the project

- If you dont want to build the project, you can download the latest stable release here: https://github.com/AntShares/AntSharesCore/releases

- If you do want to build the project, you should clone/download this repository


### Building Project

change diretory to the project repository and restore packages by using the following command

```
nuget restore AntsharesCore.sln
```

You can now build the project with `dotnet`:

```
cd $PROJECT_ROOT/AntSharesDaemon
dotnet build
```

or you can build the daemon with `msbuild` which is part of the Mono Framework

```
cd $PROJECT_ROOT/AntSharesDaemon
msbuild
```

This should build the application to `$PROJECT_ROOT/AntSharesDaemon/bin/Debug/netcoreapp1.0/AntSharesDaemon.dll`


### Running the project

Now that you have downloaded a release, or built the Daemon, you can run it with the following

```
cd to/wherever/AntsharesDaemon.dll/is
dotnet AntsharesDaemon.dll
```

To run the Daemon with the RPC service, use the following:
```
dotnet AntsharesDaemon.dll /rpc
```

That should do it.  You can interact with the Daemon via the `>ant` prompt



# Linux Instructions

You will have to first install the .NET Core libraries for your Linux Flavor. Instructions on how to do this are here: https://www.microsoft.com/net/core#linuxredhat

Secondly, you'll need the Mono Framework libraries to build the project.  Instructions for your platform are here: http://www.mono-project.com/download/#download-lin-centos

After that, you should be able to follow the directions for OSX to get the project, build, and run it.

