// beecrowd | 1035
// Selection Test 1
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values). Otherwise, write the message “Valores nao aceitos” (Values not accepted).

// Input
// Four integer numbers A, B, C and D.

// Output
// Show the corresponding message after the validation of the values​​.
using System; 

class URI {

    static void Main(string[] args) { 

        int a,b,c,d;
        string[] line1 = (Console.ReadLine()).Split(' ');
        a = int.Parse(line1[0]);
        b = int.Parse(line1[1]);
        c = int.Parse(line1[2]);
        d = int.Parse(line1[3]);

        if (b > c && d > a && (c + d) > (a + b) && c >= 0 && d >= 0 && (a % 2) == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }

}