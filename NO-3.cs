using System;

class YOlo {
   /* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */


    /* a seemingly simple task, but unfortunately factoring large 
       numbers takes a shit load of time and thus the code
       must be as optimised as possible, i will sit on the challenge for a while,
       whilst i absorb some math on factoring :) */

    static void Main() {


    }
}

static class check {
    public static bool if_prime(ulong number) {

        bool returnholder = true;

        for (ulong x = 3; x < number; x+=2) {
            if (number % x == 0)
            {
                returnholder = false;
            }
        }
        return returnholder;
    }
}