# Affiche la date de dernière connexion
# d'un compte local du système
$nom=Read-Host -Prompt "Saisir un nom de compte local"
$compte=[ADSI]"WinNT://./$nom"
if ($compte.path){
    Write-Host $compte.LastLogin
 }
 else{
    Write-Host "$nom non trouvé"
 }