package heritage_exercice_13;

public class Rapace extends Oiseau {
    public Rapace(){
        super();
    }

    @Override
    public String toString(){
        return super.toString() + "\t--> Je suis un rapace\n\t";
    }
}
