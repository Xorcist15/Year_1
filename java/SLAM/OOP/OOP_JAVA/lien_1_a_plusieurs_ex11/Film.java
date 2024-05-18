package lien_1_a_plusieurs_ex11;

import java.util.ArrayList;

public class Film {
    private String titre;
    private int annee;
    private String realisateur;
    ArrayList<Acteur> acteurs;

    public void printName(String nomActeur){
        System.out.println(nomActeur);
    }

    public Film(String titre, int annee, String realisateur){
        this.titre = titre;
        this.annee = annee;
        this.realisateur = realisateur;
        this.acteurs = new ArrayList<>();
    }
    
    @Override
    public String toString(){
        String descrip;

        descrip =  this.titre+" ("+this.annee+")\n";
        descrip += "De "+this.realisateur+"\n";
        descrip += "Avec:\n";

        for(int i=0 ; i<acteurs.size() ; i++){
            descrip += "\t"+acteurs.get(i).getPrenom() +" "+ acteurs.get(i).getNom()+"\n";
        }
        return descrip;
    }

    public void ajouterActeur(Acteur acteur){
        this.acteurs.add(acteur);
    }

}
