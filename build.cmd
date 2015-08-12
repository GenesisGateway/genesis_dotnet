@echo off

if "%~1"=="" (
  set config=Release
) else (
  set config=%1
)

if "%~2"=="" (
  set outputDir=bin
) else (
  set outputDir=%2
  set outputDir=%outputDir:/=\%
)

msbuild Genesis.NET\Genesis.NET.csproj /p:Configuration=%config% /t:"Rebuild"

md %outputDir%
xcopy Genesis.NET\bin\%config% %outputDir% /S /Y /K
