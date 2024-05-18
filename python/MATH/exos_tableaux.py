# Exo 39
# 1 un tableau est une structure de données qui sert à contenir plusieurs valeurs dans la même variable
# 2 tab = []
# 3 tab[i]
# 4 parcourir un tableau
# tab = [1, 2, 3]
# for i in range(len(tab)):
#     print(tab[i])
# 5 tab = tab_1 + tab_2
# 6 tab += []
# 7 tab taille n, elt aléa
# import random
# n = 10
# tab = []
# for i in range(n):
#     tab += [random.randint(1, 10)]
# print(tab)
# print(len(tab))

# EXO 40 algo replace 3 by 8
# tab = [3, 1, 2, 3, 8, 9, 3]
# for i in range(len(tab)):
#     if tab[i] == 3:
#         tab[i] = 8
# print(tab)

# EXO 41
# def affiche_tab(tab):
#     for i in range(len(tab)):
#         print(tab[i])

# EXO 42
# def somme(tab):
#     sum_tab = 0
#     for i in range(len(tab)):
#         sum_tab += tab[i]    
#     return sum_tab

# tab = [2 ,4, 10]
# print(somme(tab))

# def compte(val, tab):
#     compteur = 0

#     for i in range(len(tab)):
#         if tab[i] == val:
#             compteur += 1
#     return compteur

# tab = [8, 4, 1, 8, 10, 8]
# print(compte(8, tab))

# def maximum(tab):
#     max = tab[0]
#     for i in range(len(tab)):
#         if max < tab[i]:
#             max = tab[i]
#     return max

# tab = [1, 42, 8, 5]
# print(maximum(tab))

# import random
# n = int(input("Saisir n : "))
# tab = []
# for i in range(n):
#     tab += [random.randint(1, 10)]

# print(tab)

# i = int(input("Saisir i: "))
# j = int(input("Saisir j: "))

# if i % 2 == 0 and j % 2 == 0:
#     print("Case blanche")
# else:
#     print("black square")

# Exo 17 Cavaliers

def position_valide(x, y):
    return 0 <= x < 8 and 0 <= y < 8

def peut_se_deplacer(x, y, x_dest, y_dest):
    
    if not position_valide(x_dest, y_dest):
        return False

    mouvements_possibles = [
        (x+2, y+1), (x+2, y-1), (x-2, y+1), (x-2, y-1),
        (x+1, y+2), (x+1, y-2), (x-1, y+2), (x-1, y-2)
    ]
    
    for mv_x, mv_y in mouvements_possibles:
        if mv_x == x_dest and mv_y == y_dest:
            return True
    return False

x_initial = int(input("coordonnée x initiale: "))
y_initial = int(input("coordonnée y initiale: "))

if position_valide(x_initial, y_initial):
    print(f"position valide ({x_initial}, {y_initial})")
else:
    print("position invalide")

x_destination = int(input("coordonnée x destination: "))
y_destination = int(input("coordonnée y destination: "))

if peut_se_deplacer(x_initial, y_initial, x_destination, y_destination):
    print(f"Deplacement valide ({x_destination}, {y_destination})")
else:
    print("Deplacement invalide")

