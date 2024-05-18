
public class Avion {
    // props
    private String immat;           // unused
    private String constructeur;
    private String modele;

    // constructs
    public Avion(String immat, String constructeur, String modele){
        this.immat = immat;
        this.constructeur = constructeur;
        this.modele = modele;
    }

    @Override
    public String toString(){
        return this.constructeur + " " + this.modele + "\n";
    }
}
