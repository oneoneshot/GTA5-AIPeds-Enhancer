
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
{
    if(-not (Test-Path -Path $fxServerBinary))
    {
        return -1
    }

    # Take the first line of --version
    $versionOutput = & $fxServerBinary --version | Select-Object -First 1

    if(-not ($versionOutput -match '.*v\d+\.\d+\.\d+\.(\d+).*'))
    {
        return -1
    }

    return $Matches[1]
}

function Install-Z7ip
{
    Write-Information "Installing 7Zip"
    $dlurl = 'https://7-zip.org/' + (Invoke-WebRequest -UseBasicParsing -Uri 'https://7-zip.org/' | Select-Object -ExpandProperty Links | Where-Object {($_.outerHTML -match 'Download')-and ($_.href -like "a/*") -and ($_.href -like "*-x64.exe")} | Select-Object -First 1 | Select-Object -ExpandProperty href)
    # modified to work without IE
    # above code from: https://perplexity.nl/windows-powershell/installing-or-updating-7-zip-using-powershell/
    $installerPath = Join-Path $env:TEMP (Split-Path $dlurl -Leaf)
    Invoke-WebRequest $dlurl -OutFile $installerPath
    Start-Process -FilePath $installerPath -Args "/S" -Verb RunAs -Wait
    Remove-Item $installerPath
}

Function Expand-7Zip {
    [CmdletBinding(HelpUri='http://gavineke.com/PS7Zip/Expand-7Zip')]
    Param(
        [Parameter(Mandatory=$True,Position=0,ValueFromPipelineByPropertyName=$True)]
        [ValidateScript({$_ | Test-Path -PathType Leaf})]
        [System.IO.FileInfo]$FullName,

        [Parameter()]
        [Alias('Destination')]
        [ValidateNotNullOrEmpty()]
        [string]$DestinationPath,

        [Parameter()]
        [switch]$Remove
    )
    
    Begin 
    {
        if(-not (Get-Command -Name $7zaBinary -ErrorAction SilentlyContinue))
        {
            Install-Z7ip
        }
    }
    
    Process {
        Write-Verbose -Message 'Extracting contents of compressed archive file'
        If ($DestinationPath) {
            & "$7zaBinary" x -o"$DestinationPath" "$FullName"
        } Else {
            & "$7zaBinary" x "$FullName"
        }

        If ($Remove) {
            Write-Verbose -Message 'Removing compressed archive file'
            Remove-Item -Path "$FullName" -Force
        }
    }
    
    End {}
    
}
