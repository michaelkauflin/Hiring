@ECHO off
REM This script fetches the bootstrapper NuGet and passes control to the bootstrapper.
REM This is all this script should do, don't add other logic here. All working copy
REM initialization should be carried out by the bootstrapper.

nuget install Sonova.Bootstrapper -Version 2.1.0 -Source https://artifacts.sonova.com/artifactory/api/nuget/components-production-local -ExcludeVersion -OutputDirectory "%~dp0\Build" > con < con
call "%~dp0\Build\Sonova.Bootstrapper\tools\Bootstrap.bat" paket 4.8.8

@ECHO on
