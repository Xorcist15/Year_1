<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
    <h1>Interroger la base des films</h1>
    <h3>Chercher par identifiant</h3>
    <form action="select.php" method="post">
        Numéro du film à rechercher : 
        <input type="text" name="numfilm">
        <input type="submit" value="Rechercher">
    </form>
    <h3>Chercher par nom du film</h3>
    <form action="select.php" method="post">
        Numéro du film à rechercher : 
        <input type="text" name="titrefilm">
        <input type="submit" value="Rechercher">
    </form>
</body>
</html>
