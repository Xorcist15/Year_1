package lien_1_a_1;

public class LigneCommande {

    private int quantite;
    private Article article;

    public LigneCommande(int quantite, Article article){
        this.quantite = quantite;
        this.article = article;
    }

    public float montantLigne() {        
        return 0f;
    }

    @Override
    public String toString() {
        float totalLigne = this.article.getPrixVente() * this.quantite;
        return String.format("%-5s %-5s %-5.2f %-2s %-3d %.2f", this.article.getRef(), this.article.getLibelle(), this.article.getPrixVente(), " x ", this.quantite, totalLigne);

    }

    
}
