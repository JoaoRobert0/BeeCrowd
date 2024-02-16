// beecrowd | 1036
// Bhaskara's Formula
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read 3 floating-point numbers. After, print the roots of bhaskara’s formula. If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”.

// Input
// Read 3 floating-point numbers (double) A, B and C.

// Output
// Print the result with 5 digits after the decimal point or the message if it is impossible to calculate.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split();
        double a = double.Parse(line[0]);
        double b = double.Parse(line[1]);
        double c = double.Parse(line[2]);

        double delta = (b * b) - 4 *a *c;
        if (delta < 0 || a == 0){
            Console.WriteLine("Impossivel calcular");
        }
        else{
            double r1 = (-b + Math.Sqrt(delta)) / (2.0*a);
            double r2 = (-b - Math.Sqrt(delta)) / (2.0*a);
            Console.WriteLine($"R1 = {r1:f5}\nR2 = {r2:f5}");
        }

    }

}