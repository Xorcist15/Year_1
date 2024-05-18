package AP.Mission_9;

import java.io.*;
import java.text.DecimalFormat;
import java.util.ArrayList;

public class Reservation {
    // props
    private int numero;
    private String typeCarte;
    private ArrayList<Personne> lesPersonnes;
    private ArrayList<Vehicule> lesVehicules;
    private Vehicule leVehicule;
    private Traversee traversee;

    // constructs
    public Reservation(int numero, String typeCarte, Traversee traversee){
        this.numero = numero;
        this.typeCarte = typeCarte;
        this.traversee = traversee;
        lesPersonnes = new ArrayList<Personne>();
        lesVehicules = new ArrayList<Vehicule>();
    }
    // methods
    public void ajouterPersonne(
        int numero, 
        String nom, 
        String prenom, 
        String type,
        boolean referent, 
        float tarif
    ){
        if(this.traversee.getNbPassagers() > lesPersonnes.size()){
            lesPersonnes.add(
                new Personne(
                    numero, 
                    nom, 
                    prenom,
                    type, 
                    referent, 
                    tarif
                )
            );
        }
    }
    public void ajouterVehicules(
        int numero,
        String immatriculation,
        String modele,
        String categorie,
        float tarif){
            lesVehicules.add(
                new Vehicule(
                    numero,
                    immatriculation,
                    modele,
                    categorie,
                    tarif
                )
            );
    }
    public void setLeVehicule(
        int numero,
        String immatricule, 
        String modele, 
        String categorie, 
        float tarif
    ){
        this.leVehicule = new Vehicule(
            numero,
            immatricule, 
            modele, 
            categorie, 
            tarif
        );
    }
    private float calculTotal(){
        float total = 0;
        for(Personne p : lesPersonnes){
            total += p.getTarif();
        }
        total += leVehicule.getTarif();
        return total;
    }    
    @Override
    public String toString(){
        String recap = "";
        recap += traversee.toString();
        recap += "Type de tarif : " + this.typeCarte + "\n\n";
        recap += "Les personnes\n";
        for (Personne p : lesPersonnes) {
            recap += p.toString();
        }
        recap += "\n";
        recap += "Les véhicules\n";
        recap += this.leVehicule.toString();

        float total = calculTotal();
        recap += String.format("\n%45s %11.2f €", "Total", total);

        return recap;
    }
    public void toHtml(){
        try {
            File html = new File(
                "D:\\SIO\\SLAM\\OOP\\OOP_JAVA\\AP\\Mission_9\\" + 
                String.valueOf(this.numero) +
                ".html"
            );

            FileWriter writer = new FileWriter(html);
            writer.write(htmlScript());
            writer.close();
        } catch (Exception e) {
            System.out.println("Erreur lors de la création du fichier");
        }
    }
    private String htmlScript(){
        DecimalFormat df = new DecimalFormat("#0.00");
        String html = "";
        html += "<html>";
        html += "<style>";
        html += "    table {";
        html += "        border-collapse: collapse;";
        html += "    }";
        html += "    td, th{";
        html += "        border: 1px solid black;";
        html += "        padding: 8px;";
        html += "    }";
        html += "    img{";
        html += "        display: block;";
        html += "        margin-left: auto;";
        html += "        margin-right: auto;";
        html += "        width: 50%;";
        html += "    }";
        html += "</style>";
        html += "<body>";
        html += "    <header>";
        html += "        <img src=\"compagnie-oceane.jpg\" alt=\"logo compagnie océane\">";
        html += "    </header>";
        html += "    <h1>Réservation n°: "+String.valueOf(this.numero)+"</h1>";
        html += "    <h3>Ile</h3>";
        html += "    <p>Groix</p>";
        html += "    <h3>Liaison</h3>";
        html += "    <p>" + 
                this.traversee.getPortDepart().getNom() + 
                " ==> " + 
                this.traversee.getPortArrivee().getNom() + 
                "</p>";
        html += "    <h3>Date</h3>";
        html += "    <p>" + this.traversee.getDateDepart() + "</p>";

        html += "    <h3>Heure</h3>";
        html += "    <p>" + this.traversee.getHeureDepart() + "</p>";

        html += "    <h3>Les personnes</h3>";
        html += "    <table>";
            for(Personne p : lesPersonnes){
                html += "        <tr>";
                html += "            <td>" + p.getNumero() + "</td>";
                html += "            <td>" + p.getNom() + " - " + p.getPrenom() + "</td>";
                html += "            <td>" + p.getType() + "</td>";
                if(p.getTarif() == 0){
                    html += "            <td>" + "Gratuit" + "</td>";
                } else {
                    html += "            <td>" + df.format(p.getTarif()) + " €</td>";
                }
                html += "        </tr>";
            }
        html += "    </table>";

        html += "    <h3>Les véhcules</h3>";
        html += "    <table>";
        if(lesVehicules.size() != 0){
            for(Vehicule v : lesVehicules){
                html += "        <tr>";
                html += "            <td>" + v.getNumero() + "</td>";
                html += "            <td>" + v.getImmatricule() + " - " + v.getModele() + "</td>";
                html += "            <td>" + v.getCategorie() + "</td>";
                html += "            <td>" + df.format(v.getTarif()) + " €</td>";
                html += "        </tr>";
            }
        }
        else{
            html += "        <tr>";
            html += "            <td>" + leVehicule.getNumero() + "</td>";
            html += "            <td>" + leVehicule.getImmatricule() + " - " + leVehicule.getModele() + "</td>";
            html += "            <td>" + leVehicule.getCategorie() + "</td>";
            html += "            <td>" + df.format(leVehicule.getTarif()) + " €</td>";
            html += "        </tr>";
        }
        html += "    </table>";
        html += "    <br>";

        html += "    <span>Total : " + df.format(this.calculTotal()) + " €</span>";
        html += "</body>";
        html += "</html>";
       
        return html;
    }
}
