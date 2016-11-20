goodNumbers= []
for i in range(100, 354294):
    sumOfDigits = [pow(int(j), 5) for j in str(i)]
    if sum(sumOfDigits) == i:
        goodNumbers.append(i)

print sum(goodNumbers)