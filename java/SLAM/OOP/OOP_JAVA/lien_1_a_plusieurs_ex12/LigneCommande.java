public class LigneCommande {

    private int quantite;
    private Article article;

    public LigneCommande(int quantite, Article article){
        this.quantite = quantite;
        this.article = article;
    }

    public float MontantLigne() {        
        return (float) this.article.getPrixVente()*this.quantite;
    }

    @Override
    public String toString() {
        return String.format(
            "%-10s %-10s %-5.2f %-2s %-10d %.2f",
            this.article.getRef(), this.article.getLibelle(),
            this.article.getPrixVente(), " x ", this.quantite,
            this.MontantLigne()
        );
    }   
}
