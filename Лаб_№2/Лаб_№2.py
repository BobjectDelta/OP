print('Enter a1 and a2')
a1 = int(input())
a2 = int(input())
print('Enter b1 and b2')
b1 = int(input())
b2 = int(input())
print('Enter c1 and c2')
c1 = int(input())
c2 = int(input())
det = a1*b2 - b1*a2
det1 = c1*b2 - b1*c2
det2 = a1*c2 - c1*a2
if det != 0:
    count = '1'
elif det1 == det2 == 0:
    count = 'Infinity'
else:
    count = '0'
print(count)