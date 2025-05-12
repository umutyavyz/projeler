@echo off
setlocal EnableDelayedExpansion

:: Eski ve yeni proje adlarını tanımla
set "oldName=AracKiralamaUygulaması"
set "newName=FilmKiralama"

echo === '%oldName%' ismi '%newName%' ile değiştiriliyor... ===

:: Uygun uzantılara sahip dosyalarda değişiklik yap
for %%F in (*.sln *.csproj *.cs *.config *.Designer.cs *.resx) do (
    for /r %%i in (%%F) do (
        echo - İşleniyor: %%i
        powershell -Command "(Get-Content -Raw -Encoding UTF8 '%%i') -replace '%oldName%', '%newName%' | Set-Content -Encoding UTF8 '%%i'"
    )
)

echo === Değiştirme işlemi tamamlandı ===
pause
