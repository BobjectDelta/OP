def Tailor():
    global x
    global e
    global arctg
    i = 2
    elem = x
    y = x

    while abs(elem) > e:
        elem = (-elem * x * x) / (i+1)
        y += elem
        i += 2

    i = 2
    if x > 1:
        elem = x - 5
        while abs(elem) > e:
            elem = (-elem * (x-5) * (x-5)) / (i+1)
            arctg += elem
            i += 2
        y = y / arctg
        print(y)

    if x >= 0 and x <= 1:
        elem = 2*x
        while abs(elem) > e:
            elem = (-elem * 4 * x* x) / (i + 1)
            arctg += elem
            i += 2
        y = y / arctg
        print(y)

print('Enter x (>=0): ')
x = float(input())
arctg = x
print('Enter e (>0 and <1): ')
e = float(input())
Tailor()