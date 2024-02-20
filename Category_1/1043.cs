// beecrowd | 1043
// Triangle
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read three point floating values (A, B and C) and verify if is possible to make a triangle with them. If it is possible, calculate the perimeter of the triangle and print the message:


// Perimetro = XX.X


// If it is not possible, calculate the area of the trapezium which basis A and B and C as height, and print the message:


// Area = XX.X

// Input
// The input file has tree floating point numbers.

// Output
// Print the result with one digit after the decimal point.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split();
        double a = double.Parse(line[0]);
        double b = double.Parse(line[1]);
        double c = double.Parse(line[2]);
        
        if (a + b > c && a + c > b && b + c > a){
            Console.WriteLine($"Perimetro = {a+b+c:f1}");
        }
        else {
            Console.WriteLine($"Area = {(a+b)*c/2:f1}");
        }

    }

}