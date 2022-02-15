s, n  = map( str, input().split())
n = int(n)
a = list()
sum = 0
for i in range(1, n+1):
    a.append((" "*(n-i) + s*(2*i -1)))
    sum += n + i - 1
print(sum)
for i in range(0, len(a)):
    print(a[i])
