package heritage_exercice_13;

public class Vautour extends Rapace {
    public Vautour(){
        super();
    }

    @Override
    public String toString(){
        return super.toString() + "\t--> J'appartiens à la famille des vautours\n\t\t";
    }
}
