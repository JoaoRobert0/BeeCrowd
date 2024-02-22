// beecrowd | 1044
// Multiples
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read two integer values (A and B). After, the program should print the message "Sao Multiplos" (are multiples) or "Nao sao Multiplos" (aren’t multiples), corresponding to the read values.

// Input
// The input has two integer numbers.

// Output
// Print the relative message to the input as stated above.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split();
        int x = int.Parse(line[0]);
        int y = int.Parse(line[1]);
        
        if (x > y)
        {
            if (x % y == 0) Console.WriteLine("Sao Multiplos");
            else Console.WriteLine("Nao sao Multiplos");
        }
        else
        {
            if (y % x == 0) Console.WriteLine("Sao Multiplos");
            else Console.WriteLine("Nao sao Multiplos");
        }

    }

}