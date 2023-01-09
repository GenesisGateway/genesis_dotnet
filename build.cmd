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

msbuild Genesis.NETCore\Genesis.NetCore.csproj /p:Configuration=%config% /t:"Rebuild"

md %outputDir%
xcopy Genesis.NETCore\bin\%config% %outputDir% /S /Y /K
