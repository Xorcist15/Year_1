# Script de parcours d'un fichier texte
# Contenu du fichier : nomCompte/nomComplet/Description
# Affiche le nom du compte

$fichier="C:\testPowerShell\listeCompte.txt"

if (Test-Path $fichier){
    $colLIgnes=Get-Content $fichier
    
    foreach($ligne in $colLignes){
        $tabCompte=$ligne.Split("/")
        Write-Host $tabCompte[0]
    }
}
else{
    Write-Host "$fichier pas trouvé"
}