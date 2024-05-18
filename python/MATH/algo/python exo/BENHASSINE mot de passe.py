## youssef

MOT_DE_PASSE = "James-Bob"

BON = False
while (not BON):
    mdp = input("Saisir mot de passe: ")
    if mdp == "James-Bob":
        BON = True
    else:
        print("Mauvais mot de passe")

print("mot de passe bon", MOT_DE_PASSE)