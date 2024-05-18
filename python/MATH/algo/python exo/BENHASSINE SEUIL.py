### youssef
def seuil(Seuil):
    surface_nenuphar = 9
    i = 0

    while surface_nenuphar < Seuil:
        ### incrementation * 1.2
        surface_nenuphar *= 1.2
        i += 1
    print("nouvelle surfce du nénuphar = ", surface_nenuphar)
    print("le nombre de mois pour atteindre", Seuil, "est de", i, "mois")



Seuil = int (input("Entrez le seuil du nénphar: "))
seuil(Seuil)


