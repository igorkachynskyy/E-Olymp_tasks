x = int(input())
p = 0
if x == 0:
    p += 1
while x > 0:
    x //= 10
    p += 1
print(p)
