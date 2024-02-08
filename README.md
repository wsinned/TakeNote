# Take Note

A note taking cli helper implemented in dotnet.

## Getting started

After cloning the repo, enter the Nix Shell development environment:

```
nix-shell --run zsh
```

Restore any external packages with Paket:

```
paket restore
```

Run the tests:

```
dotnet test
```

Run the main application:

```
dotnet run --project TakeNote.Cli
```
