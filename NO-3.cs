using System;

class YOlo {
   /* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */

    static void Main() {

        Console.WriteLine(check.if_prime(10007));
        Console.ReadKey();
    }
}

static class check {
    public static bool if_prime(ulong number) {

        bool returnholder = true;

        for (ulong x = 2; x < number; x++) {
            if (number % x == 0)
            {
                returnholder = false;
            }
        }
        return returnholder;
    }
}