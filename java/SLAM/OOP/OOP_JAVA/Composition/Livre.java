package Composition;

import java.util.ArrayList;

public class Livre {
    // props
    private String isbn;
    private String titre;
    private String titreBis;
    private ArrayList<Chapitre> lesChapitres;
    private ArrayList<Auteur> lesAuteurs;

    // constructs
    public Livre (String isbn, String t, String tb){
        this.isbn = isbn;
        this.titre = t;
        this.titreBis = tb;
        this.lesChapitres = new ArrayList<Chapitre>();
        this.lesAuteurs = new ArrayList<Auteur>();
    }

    // methods
    public void ajouterAuteur (Auteur unAuteur){
        this.lesAuteurs.add(unAuteur);
    }

    public void ajouterChapitre (int numero, String titre, int page){
        this.lesChapitres.add(new Chapitre(numero, titre, page));
    }
    @Override
    public String toString(){
        String recap = "";
        for(Auteur auteur : lesAuteurs){
            recap += auteur.getPrenom() + " " + auteur.getNom() + "\t";
        }
        recap += "\n";
        for(Chapitre chap : lesChapitres){
            recap += chap.toString();
        }
        
        return recap;
    }
}