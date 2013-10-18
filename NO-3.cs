using System;

class YOlo {
   /* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */

    static void Main() {
        ulong number = 10007;
        Console.WriteLine(meth.check_if_prime(number));
        Console.ReadKey();

    }
}

static class meth {
    public static bool check_if_prime(ulong number) {

        for (ulong x = 3; x <= number; x+=2) {
            if ((number % x) == 0)
            {
                return false;
            }
        }
        return true;
    }
}

