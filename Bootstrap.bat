@ECHO off
REM This script fetches the bootstrapper NuGet and passes control to the bootstrapper.
REM This is all this script should do, don't add other logic here. All working copy
REM initialization should be carried out by the bootstrapper.

nuget install Sonova.Bootstrapper -Version 1.3.1 -ExcludeVersion -OutputDirectory "%~dp0\Build" > con < con
call %~dp0\Build\Sonova.Bootstrapper\tools\Bootstrap.bat

@ECHO on