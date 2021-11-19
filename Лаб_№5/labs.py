a = int(input())
a_minus = a
a_plus = a
not_prime1 = True
not_prime2 = True
while not_prime1 and not_prime2:
    a_minus -= 1
    a_plus += 1
    i = 2
    j = 2
    not_prime1 = False
    not_prime2 = False
    while (i < a_minus and not not_prime1):
        if a_minus % i == 0:
            not_prime1 = True
        else:
            not_prime1 = False
        i += 1
    while (j < a_plus and not not_prime2):
        if a_plus % j == 0:
            not_prime2 = True
        else:
            not_prime2 = False
        j += 1
if not_prime1 == False:
    print(a_minus, " is the nearest prime number")
else:
    print(a_plus, " is the nearest prime number")