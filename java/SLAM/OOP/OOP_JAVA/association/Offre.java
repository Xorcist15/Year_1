package association;

public class Offre {
    private float prixAchat;
    private int delaiLivraison;
    private int delaiPaiement;
    private Fournisseur leFournisseur;

    public Offre(
        Fournisseur fournisseur, 
        float prixAchat, 
        int delaiLivraison, 
        int delaiPaiement){
            this.leFournisseur = fournisseur;
            this.prixAchat = prixAchat;
            this.delaiLivraison = delaiLivraison;
            this.delaiPaiement = delaiPaiement;
    }

    @Override
    public String toString(){
        String res = "\n\tFournisseur: " + this.leFournisseur.getNom();
        res += "\n\tPrix d'achat : " + this.prixAchat + "€";
        res += "\n\tDélai de livraison : " + this.delaiLivraison + " jours";
        res += "\n\tDélai de paiement : " + this.delaiPaiement + " jours";
        res += "\t\n---------------------------------------\n";
        return res;
    }

    public Fournisseur getLFournisseur(){
        return this.leFournisseur;
    }
}
