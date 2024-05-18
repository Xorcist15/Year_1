package Composition;

public class Chapitre {
    // props
    private int numero;
    private String titre;
    private int page;

    // constructs
    public Chapitre(int n, String t, int p){
        this.numero = n;
        this.titre = t;
        this.page = p;
    }

    // methods
    @Override
    public String toString(){
        String recap = String.format("%-10s %-4d %-25s %s\n", "Chapitre", this.numero, this.titre, this.page);
        return recap;
    }
}
