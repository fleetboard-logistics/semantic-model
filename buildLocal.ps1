$env:VSINSTALLDIR="C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional"
$env:VisualStudioVersion="15.0"

Write-Host building semantic models... -ForegroundColor DarkGreen
dotnet build 

Write-Host building nuget packages -ForegroundColor DarkGreen
dotnet pack src/Conizi.Model/Conizi.Model.csproj --output nupkgs /p:NuspecFile=Conizi.Model.nuspec
dotnet pack src/Conizi.Model.Core/Conizi.Model.Core.csproj --output nupkgs /p:NuspecFile=Conizi.Model.Core.nuspec

Write-Host building docfx docu... -ForegroundColor DarkGreen
C:\tmp\docfx\docfx docs/docfx.json

$pathDocu="../fleetboard-logistics.github.io/docs/conizi/semantic-models/site"

Write-Host copy files to flelo docu... -ForegroundColor DarkGreen
if(Test-Path $pathDocu) {
    Remove-Item $pathDocu -Recurse
}



New-Item $pathDocu -ItemType Directory
Copy-Item "docs/_site/*" -Destination $pathDocu/ -Recurse
