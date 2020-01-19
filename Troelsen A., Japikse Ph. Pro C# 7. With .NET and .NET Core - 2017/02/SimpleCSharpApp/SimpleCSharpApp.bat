
@echo off

rem Пакетный файл для приложения SimpleCSharpApp.exe
rem в котором захватывается возвращаемое им значение

.\SimpleCSharpApp\bin\Debug\SimpleCSharpApp
@if "%ERRORLEVEL%" == "0" GOTO success

:fail 
    rem приложение потерпело неудачу
    echo This app has failed!
    echo return value = %ERRORLEVEL%
    goto end

:success 
    rem 
    echo This app has suuceeded!
    echo return value = %ERRORLEVEL%
    goto end

:end
    rem Work if done
    echo All done
