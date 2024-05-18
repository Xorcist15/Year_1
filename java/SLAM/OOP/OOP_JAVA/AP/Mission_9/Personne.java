package AP.Mission_9;

public class Personne {
    // props
    private int numero;
    private String nom;
    private String prenom;
    private String type;
    private boolean referent;
    private float tarif;

    // contructs
    public Personne(
        int numero, 
        String nom, 
        String prenom, 
        String type, 
        boolean referent, 
        float tarif){
            this.numero = numero;
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.referent = referent;
            this.tarif = tarif;
    }

    // getters setters
    public int getNumero(){
        return this.numero;
    }
    public String getNom(){
        return this.nom;
    }
    public String getPrenom(){
        return this.prenom;
    }
    public String getType(){
        return this.type;
    }
    public float getTarif(){
        return this.tarif;
    }
    // toString
    @Override
    public String toString(){
        // TODO la mise en page est moche 'pas aligné'
        String recap = "";

        if(this.referent){
            recap += String.format("\t%-13s", "(Référent)");
        } else {
            recap += String.format("\t%-13s", "");
        }

        if(this.tarif == 0){
            String t = "gratuit";
            recap += String.format(
                "%s %-10s %s %s %-8s %s\n", 
                this.numero, 
                this.prenom, 
                this.nom, 
                "-", 
                this.type, 
                t);
        } else {
            recap += String.format(
                "%s %-10s %s %s %-8s %.2f €\n", 
                this.numero, 
                this.prenom, 
                this.nom, 
                "-", 
                this.type, 
                this.tarif
            );
        }

        

        return recap;
    }
}
