package Exercice_Comptes;

import java.util.Scanner;

public class Compte {

    private int numero;
    private String nom;
    private float decouvert;
    private float solde;
    private String motDePasse;

    public Compte(int numero, String nom, String motDePasse){
        this.numero = numero;
        this.nom = nom;
        this.motDePasse = motDePasse;
        this.solde = 0;
        this.decouvert = 0;
    }
    public Compte(int numero, String nom){
        this.numero = numero;
        this.nom = nom;
        this.motDePasse = "0000";
        this.solde = 0;
        this.decouvert = 0;
    }

    public void crediter(float solde){
        this.solde += solde;
    }

    public boolean debiter(float montantRetire){

        if (this.solde - montantRetire >= -this.decouvert) {
            this.solde -= montantRetire;
            return true;
        } else {
            System.out.println("Faux");
            return false;
        }
    }
    
    @Override
    public String toString(){
        return
                "-------------------------------------\n"+
                " Numéro : " + this.numero + "\n"+
                " Nom du titulaire : " + this.nom + "\n"+
                " Découvert autorisé : " + this.decouvert +"€\n"+
                " Solde actuel : "+ this.solde +"€\n"+
                "-------------------------------------\n";
    }

    public void setDecouvert(){

        final String DEFAULT_PSWD = "0000";
        Scanner saisir = new Scanner(System.in);

        if (this.motDePasse.equals(DEFAULT_PSWD)){
            System.out.println("Votre mot de passe est 0000, veuillez le modifier");
            setMotDePasse();
        }
        System.out.print("Veuillez saisir le nouveau découvert bancaire: ");
        this.decouvert = saisir.nextFloat();
    }
    
    private void setMotDePasse(){
        Scanner saisir = new Scanner(System.in);
        System.out.print("Saisir votre nouveau mot de passe: ");

        do{
            this.motDePasse = saisir.next();
            if(!mdpVerifier(this.motDePasse)){
                System.out.print("Ressaisir le mot de passe: ");
            }
        }while(!mdpVerifier(this.motDePasse));
    }

    private boolean mdpVerifier(String motDePasse) {

        boolean valid = true;

        if (this.motDePasse.length() != 4){
            valid = false;
            System.out.println("le mot de passe ne respecte pas la longueur demandée");
        }

        if(this.motDePasse.isEmpty()){
            valid = false;
            System.out.println("le mot de passe ne peut pas etre vide");
        }

        if(this.motDePasse.isEmpty()){
            valid = false;
            System.out.println("le mot de passe ne peut etre constitué d'espace seulement");
        }

        for(int i = 0; i<motDePasse.length(); i++){
            if(motDePasse.charAt(0) == ' '){
                valid = false;
                System.out.println("le mot de passe ne peut pas contenir des espaces");

            }
        }
        return valid;
    }
}
