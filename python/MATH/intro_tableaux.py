import random
tab = []

for i in range(1, 6):
    tab += [i]

print(tab)

#   SUM
# sum = 0
# for i in range(len(tab)):
#     sum += tab[i]
# print(sum)

#   MAX
# max = tab[0]
# for i in range(len(tab)):
#     if max < tab[i]:
#         max = tab[i]
# print(max)

#   MIN
# min = tab[0]
# for i in range(len(tab)):
#     if min > tab[i]:
#         min = tab[i]
# print(min)

#   SORT
# for i in range(len(tab)):
#     for j in range(len(tab)):
#         if tab[i] < tab[j]:
#             temp = tab[i]
#             tab[i] = tab[j]
#             tab[j] = temp

# print(tab)

# REVERSE
# i = 0
# j = len(tab)-1
# while j != 0:
#     temp = tab[i]
#     tab[i] = tab[j]
#     tab[j] = temp

#     i += 1
#     j -= 1

print(tab)


