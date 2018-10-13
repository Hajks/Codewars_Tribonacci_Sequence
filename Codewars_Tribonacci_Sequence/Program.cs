using System;

//##TASK DESCRIPTION##
//Well met with Fibonacci bigger brother, AKA Tribonacci.

//    As the name may already reveal, it works basically like a Fibonacci, but summing the last 3 (instead of 2) numbers of the sequence to generate the next. And, worse part of it, regrettably I won't get to hear non-native Italian speakers trying to pronounce it :(

//    So, if we are to start our Tribonacci sequence with [1, 1, 1] as a starting input (AKA signature), we have this sequence:

//[1, 1 ,1, 3, 5, 9, 17, 31, ...]
//But what if we started with [0, 0, 1] as a signature? As starting with [0, 1] instead of [1, 1] basically shifts the common Fibonacci sequence by once place, you may be tempted to think that we would get the same sequence shifted by 2 places, but that is not the case and we would get:

//[0, 0, 1, 1, 2, 4, 7, 13, 24, ...]
//Well, you may have guessed it by now, but to be clear: you need to create a fibonacci function that given a signature array/list, returns the first n elements - signature included of the so seeded sequence.

//Signature will always contain 3 numbers; n will always be a non-negative number; if n == 0, then return an empty array and be ready for anything else which is not clearly specified ;)


namespace Codewars_Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            double[] Tribonacci(double[] signature, int n)
            {
                double[] tribonacciArray = new double[n];
                if (n <= 3)
                {
                    for (int i = 0; i < n; i++)
                    {
                        tribonacciArray[i] = signature[i];
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        tribonacciArray[i] = signature[i];
                    }
                    for (int i = 3; i < n; i++)
                    {
                        tribonacciArray[i] = tribonacciArray[i - 1] + tribonacciArray[i - 2] + tribonacciArray[i - 3];
                    }
                }
                return tribonacciArray;
            }

            //Codewars solution + code review for myself

            double[] Tribonacci2(double[] signature, int n)
            {
                double[] res = new double[n]; 
                Array.Copy(signature, res, Math.Min(3, n)); //Array.Copy first parametr is source, 2nd is destination. Math.Min is length for array. 
    
                for(int i = 3; i < n; i++)
                    res[i] = res[i - 3] + res[i - 2] + res[i - 1];
    
                return n == 0 ? new double[]{0} : res; //if n == 0, return new empty double, otherwise return our array res.
            }
        }
    }
}
