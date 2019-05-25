
$ErrorActionPreference = "Stop"

echo "Running on $env:computername..."

& {
    # $env:CI_COMMIT_REF = $CI_COMMIT_REF
    $env:CONIZI_CORE_VERSION = "19.5.0"
    $env:CI_PIPELINE_ID = "4444"
    $env:CI_COMMIT_REF_NAME = "master"
    # $env:CI_JOB_ID = $CI_JOB_ID
    # $env:CI_REPOSITORY_URL = $CI_REPOSITORY_URL
    # $env:CI_PROJECT_ID = $CI_PROJECT_ID
    # $env:CI_PROJECT_DIR = $CI_PROJECT_DIR
    # $env:CI_SERVER_NAME = $CI_SERVER_NAME
    # $env:CI_SERVER_VERSION = $CI_SERVER_VERSION
    # $env:CI_SERVER_REVISION = $CI_SERVER_REVISION
    
    $vsuffix = "-alpha";
    
    switch ($env:CI_COMMIT_REF_NAME) {
        "master" {
            $vsuffix = "-alpha"
            break;
          }

        "preproduction" {
            $vsuffix = "-beta"
          }
        
        "production" {
            $vsuffix = ""
          }

        Default {
            $vsuffix = "-alpha"
        }
    }

    Write-Host building nuget packages -ForegroundColor DarkGreen
    dotnet pack src/Conizi.Model/Conizi.Model.csproj --output nupkgs /p:NuspecFile=Conizi.Model.nuspec /p:Version=$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix --version-suffix=$vsuffix
    dotnet pack src/Conizi.Model.Core/Conizi.Model.Core.csproj --output nupkgs /p:NuspecFile=Conizi.Model.Core.nuspec /p:Version=$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix --version-suffix=$vsuffix

}