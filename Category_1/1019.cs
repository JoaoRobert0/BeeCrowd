// beecrowd | 1019
// Time Conversion
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read an integer value, which is the duration in seconds of a certain event in a factory, and inform it expressed in hours:minutes:seconds.

// Input
// The input file contains an integer N.

// Output
// Print the read time in the input file (seconds) converted in hours:minutes:seconds like the following example.
using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n/3600}:{(n%3600)/60}:{(n%3600)%60}");

    }

}