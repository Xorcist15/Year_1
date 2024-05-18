import math

def trouver_diviseurs(num):
    
    div = []
    sqrt_num = int(math.sqrt(num))
    op = 0

    for i in range(1, sqrt_num+1):
        op += 1
        if num % i == 0:    
            div.append(i)
            div.append(num // i)

    op_bub = bubble_sort(div)

    return div, op, op_bub

def bubble_sort(div):

    op = 0
    n = len(div)

    for i in range(n):
        for j in range(0, n-i-1):
            op += 1
            if div[j] > div[j+1]:
                temp = div[j]
                div[j+1] = temp
    return op

num = int(input("Enter a number: "))
div, op_div, op_bub = trouver_diviseurs(num)

print("Diviseurs:", div)
print("nb op div:", op_div)
print("nb op bubble_sort:", op_bub)
