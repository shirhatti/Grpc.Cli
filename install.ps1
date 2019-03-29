<#
.SYNOPSIS
    Builds and installs dotnet-grpc
.DESCRIPTION
    Install dotnet-grpc cli. If dotnet-grpc already exists it will update it.
.PARAMETER Action
    Default: Install
    Possible values:
      - Install
      - Uninstall
#>
[CmdletBinding()]
param(
  [Parameter()]
  [ValidateSet("Install", "Uninstall")]
  [string]$Action="Install"
)

$ErrorActionPreference = 'Stop'

if ($Action -eq "Install")
{
  dotnet pack
  dotnet tool update --global --add-source .\src\dotnet-grpc\nupkg\ dotnet-grpc
}
elseif ($Action -eq "Uninstall") {
  dotnet tool uninstall -g dotnet-grpc
}