<?php
//Utilisateur par défaut pour utiliser le SGBD avec 
//un site en phase de conception.
//Ces valeurs devront impérativement être modifiées
//lorsque le site sera en production !!
$user = 'root';
$pass = '';

try {
    $connexion = new PDO('mysql:host=localhost;port=3307;dbname=films', $user, $pass);
    //Le port 3307 correspond à MariaDB alors que le port 3306 correspond à MySQL
    
    echo "<p>Connexion etablie à la base films...</p>";

    //On vérifie que c'est bien un nombre car on ne fait jamais confiance à l'utilisateur
    //Si le contenu de $_POST['numfilm'] filtré est bien un entier on l'affecte à la variable $numFilm
    //Sinon on affecte false à la variable $numFilm
    $numFilm = filter_input(INPUT_POST,"numfilm", FILTER_VALIDATE_INT);
    
    //On vérifie que quelque chose a été saisi dans le TextBox numFilm       
    if(!empty($numFilm)){
        // REQUETE 1

        //On crée une requête SQL préparée pour éviter les injections SQL
        $requete_1 = 
        "   SELECT *
            FROM film F
            JOIN realisateur R ON R.id = F.idrealisateur
            WHERE F.id = :numFilm
        ";

        //On soumet la requête préparée au SGDB grâce à la connexion
        $commande = $connexion->prepare($requete_1);

        //On affecte une valeur au paramètre
        $commande->bindParam(':numFilm',$numFilm);

        //On exécute la requête
        $commande->execute();

        //On charge le résultat dans un curseur
        $curseur = $commande->fetchAll();

        //On teste si le curseur est vide ou non
        if (!$curseur) {
            //Le film n'existe pas
            echo "<p>Le film n°" . $numFilm . " n'est pas répertorié</p>";
        }
        else{
            //Le film existe
            //Ici on génère du code HTML
            echo "<br/>  <p>-->Film n°" . $numFilm . " trouvé...</p>";
            echo "<table border=1>" ;
            echo "<tr>  <th>Numéro</th> <th>Titre</th> <th>Realisateur</th>  </tr>"; // two columns

            //Pour chaque ligne du curseur...
            foreach($curseur as $ligne) {
                //On crée une ligne et 2 colonnes
                echo "<tr>";
                echo "<td>" . $ligne['id'] . "</td>";
                echo "<td>" . $ligne['titre'] . "</td>";
                echo "<td>" . $ligne['nom'] . "</td>";
                echo "</tr>";
            }
            echo "</table>";

            
        // REQUETE 2

        $requete_2 = 
        "   SELECT *
            FROM acteur A
            JOIN distribution D ON D.idacteur = A.id
            WHERE D.idfilm = :numfilm
            ORDER BY D.rang
        ";

        $commande_2 = $connexion->prepare($requete_2);
        $commande_2->bindParam(':numfilm',$numFilm);
        $commande_2->execute();
        $curseur_2 = $commande_2->fetchAll();

        // affichage acteurs
        echo "<p>-->Acteurs du film n°" . $numFilm . " sont : </p>";

        echo "<table border=1>" ;
        echo "<tr>  <th>Nom</th> <th>rang</th> </tr>"; // two columns

            //Pour chaque ligne du curseur...
            foreach($curseur_2 as $ligne) {
                //On crée une ligne et 2 colonnes
                echo "<tr>";
                echo "<td>" . $ligne['nom'] . "</td>";
                echo "<td>" . $ligne['rang'] . "</td>";
                echo "</tr>";
            }
            echo "</table>";
        }
    }
    else{
        echo "<p>La valeur saisie est vide ou n'est pas un nombre entier !</p>";
    }

    $titreFilm = filter_input(INPUT_POST,"titrefilm", FILTER_UNSAFE_RAW);
    if(!empty($titreFilm)){

        //On crée une requête SQL préparée pour éviter les injections SQL
        $requete = 
        "   SELECT *
            FROM film
            WHERE titre LIKE CONCAT('%', :titrefilm, '%')
        ";      

        //On soumet la requête préparée au SGDB grâce à la connexion
        $commande = $connexion->prepare($requete);

        //On affecte une valeur au paramètre
        $commande->bindParam(':titrefilm',$titreFilm);

        //On exécute la requête
        $commande->execute();

        //On charge le résultat dans un curseur
        $curseur = $commande->fetchAll();

        //On teste si le curseur est vide ou non
        if (!$curseur) {
            //Le film n'existe pas
            echo "<p>Aucune correspondance pour \"" . $titreFilm . "\".</p>";
        }
        else{
            //Le film existe
            //Ici on génère du code HTML
            echo "<p>-->Correspondance pour " . $titreFilm . "</p>";
            echo "<table border=1>" ;
            echo "<tr>  <th>Titre</th> <th>Année</th> <th>Score</th>  </tr>"; // two columns

            //Pour chaque ligne du curseur...
            foreach($curseur as $ligne) {
                //On crée une ligne et 2 colonnes
                echo "<tr>";
                echo "<td>" . $ligne['titre'] . "</td>";
                echo "<td>" . $ligne['annee'] . "</td>";
                echo "<td>" . $ligne['score'] . "</td>";
                echo "</tr>";
            }
            echo "</table>";
        }
    }
    else{
        echo "<p>La valeur saisie est vide ou n'est pas un nombre entier !</p>";
    }

    //On libère la connexion
    $connexion = null;

} 
catch (PDOException $e) {
    print "Erreur !: " . $e->getMessage() . "<br/>";
    die();
}

?>

