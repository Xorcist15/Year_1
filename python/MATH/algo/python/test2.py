import math

def div(num):
    
    div = []
    sqrt_num = int(math.sqrt(num))
    op = 0

    for i in range(1, sqrt_num+1):
        op += 1
        if num % i == 0:
            div.append(i)
            div.append(num // i)

    return div, op
num = int(input("Enter number:"))

list, op = div(num)

print("diviseurs: ", list)
print("op: ", op)