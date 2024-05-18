package articlePackage;

import javax.print.DocFlavor;

public class Article {

    private String ref;
    private String libelle;
    private float prixAchat;
    private float prixVente;
    private int stock;

    // constructeur par défaut
    public Article(String ref, String libelle, float prixVente, float prixAchat, int stock){
        this.ref = ref;
        this.libelle = libelle;
        this.prixVente = prixVente;
        this.prixAchat = prixAchat;
        this.stock = stock;
    }
    public float valeurStock(){
        return this.prixVente * this.stock;
    }
    // Méthode privée
    private float marge(){
        return prixVente-prixAchat;
    }

    @Override
    public String toString(){
        return "Référence : "+this.ref +
                "\nLibellé : "+this.libelle+
                "\nPrix de vente : "+this.prixVente+" €"+
                "\nPrix d'achat : "+this.prixAchat+" €"+
                "   (Marge : "+this.marge()+" €)"+
                "\nStock : "+this.stock+
                "   (Valeur du stock : "+this.valeurStock()+" €)";
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public int getStock(){
        return this.stock;
    }
    public String getRef(){
        return this.ref;
    }
    public String getLibelle(){
        return this.libelle;
    }
    public float getPrixVente(){
        return this.prixVente;
    }
    public float getPrixAchat(){
        return this.prixAchat;
    }
}
