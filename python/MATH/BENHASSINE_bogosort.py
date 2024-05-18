from random import *

def F(tab):
    bogotab = []
    while len(tab) > 0:
        i = randint(0, len(tab)-1)
        bogotab += [tab[i]]
        tab = tab[0:i] + tab[i : len(tab)]
    return bogotab

tableau = [8, 6, 5, 4, 3, 2, 6, 8]
print(F(tableau))
print("jjelo ")

