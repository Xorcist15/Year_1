# RMACQADMVCRIQDCRIQDIQVKC

def chiffrement_cesar(texte, decalage):
    resultat = ''
    for char in texte:
        if char.isalpha():
            if char.islower():
                resultat += chr((ord(char) - ord('a') + decalage) % 26 + ord('a'))
            else:
                resultat += chr((ord(char) - ord('A') + decalage) % 26 + ord('A'))
        else:
            resultat += char
    return resultat

# Exemple d'utilisation
texte_original = input("enter the to convert: ")
decalage = int(input("Enter the key of conversion: "))
texte_chiffre = chiffrement_cesar(texte_original, decalage)

print("Texte original:", texte_original)
print("Texte chiffré:", texte_chiffre)