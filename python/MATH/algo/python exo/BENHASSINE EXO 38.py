## YOUSSEF

import random

def quitter(prompt):
    while True:
        if input(f"{prompt}").lower() == "q":
            print("Vous avez choisi de quitter la partie")
            return False
        else:
            return True

def partie(joueur):

    print(f"tour de {joueur}")

    i = 1
    cumul_points = 0
    de = -1
    rejouer = True

    print("Tapez entrée pour jouer...")
    input()

    while i != 11 and rejouer:

        de = random.randint(1, 6)
        print(f"Lancée {i} ==> {de}")
        i += 1

        if de != 1:
            cumul_points += de
            print(f"Points actuels: {cumul_points}")
            if i != 10:
                rejouer = quitter("Relancer? [Entrée]. [q ou Q] pour quitter la partie: ")
                if not rejouer:
                    print(f"{joueur} gagne {cumul_points}")
            print()

        else:
            print(f"dés = {de}, fin de partie, aucun point gagné")

            if cumul_points != 0:
                print(f"Gain potentiel perdu: {cumul_points}")
            print()

            return 0

    return cumul_points

def affichage_points(PJ1, PJ2, J1, J2):
    print(f"points {J1} {PJ1}")
    print(f"points {J2} {PJ2}")
    print()

def test_limite(PJ1, PJ2, J1, J2):
    points_max = 100

    if PJ1 > points_max:
        print(f"{J1} gagne")
        return False
    elif PJ2 > points_max:
        print(f"{J2} gagne")
        return False

    return True

def saisir_joueurs():
    J_1 = input("Prénom du joueur 1: ")
    J_2 = input("Prénom du joueur 2: ")
    print()
    return J_1, J_2


points_joueur_1 = 0
points_joueur_2 = 0
continuer = True

joueur_1, joueur_2 = saisir_joueurs()

while continuer:
    points_joueur_1 += partie(joueur_1)
    points_joueur_2 += partie(joueur_2)

    affichage_points(points_joueur_1, points_joueur_2, joueur_1, joueur_2)
    continuer = test_limite(points_joueur_1, points_joueur_2, joueur_1, joueur_2)
