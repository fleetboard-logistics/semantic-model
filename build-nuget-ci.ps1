
$ErrorActionPreference = "Stop"

echo "Running on $env:computername..."

& {
    #$env:CI_COMMIT_REF = $CI_COMMIT_REF
    # $env:CONIZI_CORE_VERSION = "19.5.0"
    # $env:CI_PIPELINE_ID = "4444"
    # $env:CI_COMMIT_REF_NAME = "master"
    # $env:CONIZI_NUGET_API_KEY="123123"
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

    Write-Host building nuget... packages -ForegroundColor DarkGreen
    dotnet pack src/Conizi.Model/Conizi.Model.csproj --output nupkgs /p:NuspecFile=Conizi.Model.nuspec /p:Version=$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix --version-suffix=$vsuffix
    dotnet pack src/Conizi.Model.Core/Conizi.Model.Core.csproj --output nupkgs /p:NuspecFile=Conizi.Model.Core.nuspec /p:Version=$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix --version-suffix=$vsuffix

    Write-Host deploying nuget... -ForegroundColor DarkGreen
    $modelPackage = "src/Conizi.Model/nupkgs/Conizi.Model.$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix.nupkg"
    Write-Host deploying package $modelPackage... -ForegroundColor DarkGreen 
    dotnet nuget push $modelPackage -s nuget.org -k  $env:CONIZI_NUGET_API_KEY

    $corePackage = "src/Conizi.Model.Core/nupkgs/Conizi.Model.Core.$env:CONIZI_CORE_VERSION.$env:CI_PIPELINE_ID$vsuffix.nupkg"
    Write-Host deploying package $corePackage... -ForegroundColor DarkGreen 
    dotnet nuget push $corePackage -s nuget.org -k  $env:CONIZI_NUGET_API_KEY
}

if(!$?) { Exit $LASTEXITCODE }