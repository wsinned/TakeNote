{ pkgs ? import <nixpkgs> {} }:
  pkgs.mkShell {

    buildInputs = [
      pkgs.dotnet-sdk_8
      pkgs.dotnetPackages.Paket
      pkgs.dotnetPackages.NUnit
      pkgs.vscode-extensions.ms-dotnettools.csharp
    ];

    nativeBuildInputs = with pkgs.buildPackages; [

    ];
}
