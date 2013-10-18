using System;

class YOlo {
   /* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */


    /* a seemingly simple task, but unfortunately factoring large 
       numbers takes a shit load of time and thus the code
       must be as optimised as possible, i will sit on the challenge for a while,
       whilst i absorb some math on factoring :) */

    /* Example 2: What is the prime factorization of 147 ?

Can we divide 147 evenly by 2? No, so we should try the next prime number, 3:

147 ÷ 3 = 49

Then we try factoring 49, and find that 7 is the smallest prime number that works:

49 ÷ 7 = 7

And that is as far as we need to go, because all the factors are prime numbers.

147 = 3 × 7 × 7

(or 147 = 3 × 72 using exponents) */

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