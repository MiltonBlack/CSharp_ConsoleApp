@echo off
rem A Batch File for a simple C# Application
rem It captures the app's return value

dotnet run
@if "%ERRORLEVEL%" == "0" goto success

:fail
    echo This Application has Failed!
    echo return value = "%ERRORLEVEL%"
    goto end
:success
    echo The Application ran Successful!
    echo return value = "%ERRORLEVEL%"
    goto end
:end
echo All Done!!!.