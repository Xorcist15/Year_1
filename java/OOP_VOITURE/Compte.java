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
        this.decouvert = 0;
    }
    public Compte(int numero, String nom){
        this.numero = numero;
        this.nom = nom;
        this.motDePasse = "0000";
        this.decouvert = 0;
    }

    public void setDecouvert(float decouvert){
        if (this.motDePasse.equals("0000")){
            System.out.println("Votre mot de passe est 0000, veuillez le modifier");
            saisirMdp();
        }
        this.decouvert = decouvert;
    }

    private void setMotDePasse(String motDePasse){




    }
    private void saisirMdp(){
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

        if(this.motDePasse.isBlank()){
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

    public void crediter(){
        System.out.print("Saisir le montant à créditer: ");
        float solde = saisir.
        this.solde += solde;
    }

    public void debiter(float montantRetire){
        if (this.solde - montantRetire < this.decouvert) {
            this.solde -= montantRetire;
        } else {
            System.out.println("Faux");
        }
    }

}
