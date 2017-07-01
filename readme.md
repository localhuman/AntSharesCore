# Antshares Core

The https://github.com/AntShares/AntSharesCore repository is a container for the Antshares Wallet application ( UI ) as well as the Daemon, which can be used as a wallet and runs an RPC service.

This particular fork of Antshares Core is for getting the Daemon running on OSX. This fork also aims to add basic 'Claim Antshares Coins' to the Daemon RPC Service, which is currently missing.

## Antshares UI

This does not currently work on OSX.  There are a lot of issues with compiling the mono framework to get it to work.

## Antshares Daemon

This can currently be run on OSX by installing the .NET core framework from microsoft.  You can download that here:

https://www.microsoft.com/net/core#macos

After installing .NET Core and downloading a release, you can start the daemon on OSX with the following:

```
cd to/wherever/AntsharesDaemon.dll/is
dotnet AntsharesDaemon.dll
```

To run the Daemon with the RPC service, use the following:
```
dotnet AntsharesDaemon.dll /rpc
```

That should do it.  You can interact with the Daemon via the `>ant` prompt
