def insertion_sort(tab):
    for i in range(1, len(tab)):
        temp = tab[i]
        j = i-1
        while j>=0 and tab[j]>temp:
            tab[j+1] = tab[j]
            j-=1
        tab[j+1] = temp
    return tab

def selection_sort(tab):
    for i in range(len(tab)):
        min = i
        for j in range(i+1, len(tab)):
            if tab[min]>tab[j]:
                min = j
        temp = tab[i]
        tab[i] = tab[min]
        tab[min] = temp
    return tab
def bubble_sort(tab):
    for i in range(len(tab)):
        for j in range(len(tab)):
            if tab[i] < tab[j]:
                temp = tab[i]
                tab[i] = tab[j]
                tab[j] = temp
    return tab

print(selection_sort([9, 8, 7, 6, 5, 4, 3, 2, 1]))
print(insertion_sort([9, 8, 7, 6, 5, 4, 3, 2, 1]))
print(bubble_sort([9, 8, 7, 6, 5, 4, 3, 2, 1]))