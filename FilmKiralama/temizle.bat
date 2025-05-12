@echo off
echo === FilmKiralama Projesi Temizleniyor ===

:: bin ve obj klasörlerini sil
echo - bin ve obj klasörleri siliniyor...
for /d /r %%i in (bin,obj) do (
    if exist "%%i" (
        echo Siliniyor: %%i
        rmdir /s /q "%%i"
    )
)

:: .vs klasörünü sil
if exist ".vs" (
    echo - .vs klasörü siliniyor...
    rmdir /s /q ".vs"
)

:: .suo ve .user dosyalarını sil
echo - .suo ve .user dosyaları siliniyor...
del /s /q *.suo
del /s /q *.user

echo === Temizlik tamamlandı ===
pause
