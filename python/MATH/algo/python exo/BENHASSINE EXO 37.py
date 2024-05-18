import random

def trouver():
    nombre_cible = random.randint(0, 50)
    nombre_saisi = -1
    while nombre_cible != nombre_saisi:

        nombre_saisi = int(input("Saisir un nombre: "))

        if nombre_cible > nombre_saisi:
            print("Le nombre cible est supérieur au nombre entré")
        elif nombre_cible < nombre_saisi:
            print("Le nombre cible est inférieur au nombre entré")
        else:
            print("Vous avez gagné, nombre cible =", nombre_cible, "nombre saisi =", nombre_saisi)
            return

print("Bienvenue, devinez un nombre aléatoire")
trouver()