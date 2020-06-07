using System;
using System.Collections.Generic;

namespace C_Sharp {
    public static class ProductAndSum {
        public static int Method1(int n) {
        var digits = new List<int>();
        for(;n != 0; n/=10){
            digits.Add(n%10);
        }
        int a = 1;
        int b = 0;
        foreach (var c in digits) {
            a = a * c;
        }
        foreach (var c in digits) {
            b = b + c;
        }
        return a - b;
    }
    }
}