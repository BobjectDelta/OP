def count(st):
    count1 = 0
    count2 = 0
    for i in range(len(st)):
        if st[i] == '(':
            count1 += 1
            flag = True
            j = i
            while j < len(st) and flag:
                if st[j] == ')':
                    count2 += 1
                    flag = False
                j += 1
            st = st[:j-1] + '0' + st[j:]

    if count2 == count1:
        print("The number of brackets is equal")
    else:
        print("The number of brackets is not equal")


s = input('Enter your string: ')
count(s)