package association;

import java.util.ArrayList;

public class Produit {
    private int id;
    private String nom;
    private float prixVente;
    private int stock;
    private ArrayList<Offre> lesOffres;

    public Produit(int id, String nom, float prixVente, int stock){
        this.id = id;
        this.nom = nom;
        this.prixVente = prixVente;
        this.stock = stock;
        lesOffres = new ArrayList<Offre>();
    }

    public boolean ajouterOffre(
        Fournisseur fournisseur, 
        float prixAchat, 
        int delaiLivraison,
        int delaiPaiement){
            boolean ok = true;
            for(Offre o : this.lesOffres){
                if(o.getLFournisseur() == fournisseur){
                    ok = false;
                }
            }
            if(ok){
                this.lesOffres.add(
                    new Offre(
                        fournisseur, 
                        prixAchat, 
                        delaiLivraison, 
                        delaiPaiement)
                );
            }
        return ok;
    }

    @Override
    public String toString(){
        String res = "";
        res += "\n----------------------------------------";
        res += "\nProduit : " + this.nom;
        res += "\nPrix de vente : " + this.prixVente + " €";
        res += "\nStock actuel : " + this.stock;
        res += "\nFournisseurs : ";
        for(Offre o : lesOffres){
            res += "\t" + o.toString();
        }
        res += "\n----------------------------------------";
        return res;

    }
}
