#include <iostream>
#include <iomanip>
#include <math.h>
#include <string>
#include <cstdio>
#include <fstream>
using namespace std;
int sum_dig(int dig) {
    int sum = 0;
    while (dig != 0) {
        sum += dig % 10;
        dig /= 10;
    }
    return sum;
}
int main()
{
    ios::sync_with_stdio(0); cin.tie(0); cout.tie(0);
    int m;
    cin >> m;
    int k = m;
    k = 0;
    while (m - sum_dig(m) >= 0 && m != 0) {
        k++;
        m -= sum_dig(m);
    }
    cout << k;
}
