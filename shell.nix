{ pkgs ? import <nixpkgs> {} }:
  pkgs.mkShell {

    buildInputs = [
      pkgs.dotnet-sdk_8
      pkgs.dotnetPackages.Paket
      pkgs.dotnetPackages.NUnit
    ];

    nativeBuildInputs = with pkgs.buildPackages; [

    ];
}
