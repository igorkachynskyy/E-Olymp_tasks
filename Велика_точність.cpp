#include <iostream>
#include <iomanip>
#include <math.h>
#include <string>
#include <cstdio>
#include <fstream>
using namespace std;
int main()
{
    ios::sync_with_stdio(0); cin.tie(0); cout.tie(0);
    int m, n, k;
    cin >> m >> n >> k;
    int a = m / n;
    string s = to_string(a)+ ".";
    while (k != 0) {
        m %= n;
        m *= 10;
        s += to_string(m/n);
        k--;
    }

    cout << s;
}
