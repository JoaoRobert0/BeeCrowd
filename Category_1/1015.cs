// beecrowd | 1015
// Distance Between Two Points
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them, showing four decimal places after the comma, according to the formula:

// Input
// The input file contains two lines of data. The first one contains two double values: x1 y1 and the second one also contains two double values with one digit after the decimal point: x2 y2.

// Output
// Calculate and print the distance value using the provided formula, with 4 digits after the decimal point.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] l1 = Console.ReadLine().Split();
        string[] l2 = Console.ReadLine().Split();
        double x1 = double.Parse(l1[0]);
        double y1 = double.Parse(l1[1]);
        double x2 = double.Parse(l2[0]);
        double y2 = double.Parse(l2[1]);

        double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        Console.WriteLine($"{d:f4}");
        
    }

}