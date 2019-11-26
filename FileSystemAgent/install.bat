@ECHO OFF
set dotNetPath=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%dotNetPath%
echo Installing Service...
echo ######################################

rem for install
InstallUtil filesystemagent.exe

rem for uninstall
rem InstallUtil -u filesystemagent.exe
echo ######################################
echo Installed Successfully.