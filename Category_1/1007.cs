/*beecrowd | 1007
Difference
Adapted by Neilor Tonin, URI  Brazil

Timelimit: 1
Read four integer values named A, B, C and D. Calculate and print the difference of product A and B by the product of C and D (A * B - C * D).

Input
The input file contains 4 integer values.

Output
Print DIFERENCA (DIFFERENCE in Portuguese) with all the capital letters, according to the following example, with a blank space before and after the equal signal.*/
using System; 

class URI {

    static void Main(string[] args) { 

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        Console.WriteLine($"DIFERENCA = {A * B - C * D}");
    }

}