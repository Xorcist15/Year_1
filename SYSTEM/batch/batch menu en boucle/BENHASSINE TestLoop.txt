@echo off
:menu
cls
echo Menu:
echo 1. Lancer MBN
echo 2. Lancer Word
echo 3. Quitter

set /p choix=Quel programme voulez-vous executer ? : 

if "%choix%"=="1" (
    echo Vous avez choisi Option 1.
    start https://cas.monbureaunumerique.fr/login
    pause
    goto :menu
) else if "%choix%"=="2" (
    echo Vous avez choisi Option 2.
    start "Microsoft Word" "C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE"

    pause
    goto :menu
) else if "%choix%"=="3" (
    echo Option 3, Quitter.
) else (
    echo choix invalide
    pause
    goto :menu
)
