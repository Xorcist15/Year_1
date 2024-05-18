### youssef

def vente(vente_premier_jour):
    nenuphare_vendus = 0
    nenuphare_vendus += vente_premier_jour # vente du premier jour
    total = 0
    for i in range(30):
        ### incrementation * 2
        nenuphare_vendus *= 2
        i += 1
        print ("Cumul des ventes jour", i ,": ", nenuphare_vendus)
        total += nenuphare_vendus
    print ("Total de ventes", total)



vente_premier_jour = int (input("Entrez le ventes de nénuphar du premier jour: "))
vente(vente_premier_jour)


