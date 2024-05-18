### youssef
def dividers(entier):
    nb_diviseurs = 0
    i = 1
    while i <= entier // 2:
        if entier % i == 0:
            print(i, "est divisieur de", entier)
            nb_diviseurs+=1
        i+=1
    print("Le nombre de diviseurs = ", nb_diviseurs)


entier = int(input("Entrez un nombre: "))
dividers(entier)


