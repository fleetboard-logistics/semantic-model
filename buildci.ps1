$env:VSINSTALLDIR = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional"
$env:VisualStudioVersion = "15.0"

$ErrorActionPreference = "Stop"

echo "Running on $env:computername..."

& {
    # $env:CI_COMMIT_REF = $CI_COMMIT_REF
    # $env:CI_PIPELINE_ID = $CI_PIPELINE_ID
    # $env:CI_COMMIT_REF_NAME = $CI_COMMIT_REF_NAME
    # $env:CI_JOB_ID = $CI_JOB_ID
    # $env:CI_REPOSITORY_URL = $CI_REPOSITORY_URL
    # $env:CI_PROJECT_ID = $CI_PROJECT_ID
    # $env:CI_PROJECT_DIR = $CI_PROJECT_DIR
    # $env:CI_SERVER_NAME = $CI_SERVER_NAME
    # $env:CI_SERVER_VERSION = $CI_SERVER_VERSION
    # $env:CI_SERVER_REVISION = $CI_SERVER_REVISION
    
    Write-Host building semantic models... -ForegroundColor DarkGreen
    dotnet build 

    Write-Host building nuget packages -ForegroundColor DarkGreen
    dotnet pack src/Conizi.Model/Conizi.Model.csproj --output nupkgs /p:NuspecFile=Conizi.Model.nuspec -Version $env:CONIZI_CORE_VERSION 
    dotnet pack src/Conizi.Model.Core/Conizi.Model.Core.csproj --output nupkgs /p:NuspecFile=Conizi.Model.Core.nuspec $env:CONIZI_CORE_VERSION

    # Write-Host building docfx docu... -ForegroundColor DarkGreen
    # C:\tmp\docfx\docfx docs/docfx.json

    # $pathDocu="../fleetboard-logistics.github.io/docs/conizi/semantic-models/site"

    # Write-Host copy files to flelo docu... -ForegroundColor DarkGreen
    # if(Test-Path $pathDocu) {
    #     Remove-Item $pathDocu -Recurse
    # }



    # New-Item $pathDocu -ItemType Directory
    # Copy-Item "docs/_site/*" -Destination $pathDocu/ -Recurse
}