// beecrowd | 1059
// Even Numbers
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Write a program that prints all even numbers between 1 and 100, including them if it is the case.

// Input
// In this extremely simple problem there is no input.

// Output
// Print all even numbers between 1 and 100, including them, one by row.
using System; 

class URI {

    static void Main(string[] args) { 

        for (int i = 2; i < 102; i = i + 2)
        {
            Console.WriteLine(i);
        }

    }

}