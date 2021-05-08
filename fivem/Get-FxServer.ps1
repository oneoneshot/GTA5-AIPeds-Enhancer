
[CmdletBinding(DefaultParameterSetName="Version")]
param (
    [Parameter(ParameterSetName="Version")]
    [string]
    $Version,

    [Parameter(ParameterSetName="ListVersion")]
    [switch]
    $ListVersion
)

$InformationPreference = "Continue"
$versionListUri = [uri]::new('https://runtime.fivem.net/artifacts/fivem/build_server_windows/master/')
$7zaBinary = "$env:ProgramFiles\7-Zip\7z.exe"
$config = Get-Content -Path "$PSScriptRoot/FXServer.conf.json" | ConvertFrom-Json -ErrorAction Stop
$fxServerDir = Join-Path -Path $PSScriptRoot -ChildPath $config.Location
$fxServerBinary = Join-Path -Path $fxServerDir -ChildPath "FXServer.exe"

# Test the installed version meets expected version
function Get-InstalledServerVersion