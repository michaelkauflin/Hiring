@ECHO off

cd "%~dp0\Build\packages\Sonova.ToolBox.Gui\tools"

start "ToolBox" "Sonova.ToolBox.Gui.exe" -b %~dp0

@ECHO on