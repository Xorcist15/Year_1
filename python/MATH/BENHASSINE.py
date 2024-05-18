from random import randint

def F(tab):
    bogotab = []
    while len(tab) > 0:
        i = randint(0, len(tab)-1)
        bogotab += [tab[i]]
        tab = tab[0:i] + tab[i+1 : len(tab)]
    return bogotab

tableau = [int(input("saisir valeur: ")) for i in range(10)]
print(tableau)
print(F(tableau))
