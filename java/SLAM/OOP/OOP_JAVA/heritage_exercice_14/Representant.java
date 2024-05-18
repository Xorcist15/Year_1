package heritage_exercice_14;

import java.text.DecimalFormat;

public class Representant extends Salarie {
    // props priv
    private float chiffreAffaires;
    private float frais;

    // constructs
    public Representant(
        int n, 
        String nom, 
        String f, 
        float s, 
        float ca, 
        float fr){
            // création objet de la classe mére
            super(n, nom, f, s);
            
            this.chiffreAffaires = ca;
            setFrais(fr);;
    }

    // getters setters
    private void setFrais(float frais){
        if(frais <= 400){
            this.frais = frais;
        } 
        else {
            this.frais = 400;
        }
    }

    public String getNom(){
        return super.getNom();
    }

    private float calculerCommission(){
        // calcul de la commission
        if(this.chiffreAffaires >= 15000){
            // 7% si ca sup à 15k
            return (float) this.salaire * 0.07f;
        }
        else{
            // sinon c'est 4% du ca
            return (float) this.salaire * 0.04f;
        }
    }

    // méthodes publiques
    @Override
    public float getSalaire(){
        // salaire représentant = Salaire de base + frais + commission        
        return this.salaire + this.frais + calculerCommission();
    }

    public String toString(){
        DecimalFormat df = new DecimalFormat("#0.00");
        String recap = super.toString();
        recap += "Chiffre d'affaires : " + df.format(this.chiffreAffaires) + " €\n";
        recap += "Frais : " + df.format(this.frais) + " €\n";
        recap += "Frais total : " + df.format(getSalaire()) + " €\n";
        return recap;
    }
}
