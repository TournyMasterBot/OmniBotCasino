param(
	[Parameter(Mandatory=$True)][string]$build_type # Debug | Staging | Release
)
Write-Host "Executing CopyToGamePath.ps1"
Write-Host "Build Type: ${build_type}"

if($build_type -eq "Release") {
	Write-Host "Publishing OmniBot.Casino.Game.Interface"
	dotnet publish OmniBot.Casino.Game.Interface.csproj
	Write-Host "Copying build files to destination path"
	Copy-Item ..\OmniBot.Casino.Game.Interface\bin\Debug\netcoreapp3.1\publish\*.dll,..\OmniBot.Casino.Game.Interface\bin\Debug\netcoreapp3.1\publish\*.json,..\OmniBot.Casino.Game.Interface\bin\Debug\netcoreapp3.1\publish\*.config -Destination "..\..\..\Game\OmniBotCasino\Assets\CodeAssets\" -recurse -force
}