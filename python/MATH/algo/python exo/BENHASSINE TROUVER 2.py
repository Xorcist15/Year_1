## youssef
import random
i = 0
Trouver_2 = False
input("Toucher le clavier pour jour... ")
while (not Trouver_2):

    de = random.randint(1,6)
    i+=1
    print("Dé joué = ", de)
    if de == 2:
        Trouver_2 = True
    else:
        input("toucher le clavier pour rejouer... ")

print("nombre de fois joués", i)
print("Vous avez gagné ")

