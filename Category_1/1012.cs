/*beecrowd | 1012
Area
Adapted by Neilor Tonin, URI  Brazil

Timelimit: 1
Make a program that reads three floating point values: A, B and C. Then, calculate and show:
a) the area of the rectangled triangle that has base A and height C.
b) the area of the radius's circle C. (pi = 3.14159)
c) the area of the trapezium which has A and B by base, and C by height.
d) the area of ​​the square that has side B.
e) the area of the rectangle that has sides A and B.

Input
The input file contains three double values with one digit after the decimal point.

Output
The output file must contain 5 lines of data. Each line corresponds to one of the areas described above, always with a corresponding message (in Portuguese) and one space between the two points and the value. The value calculated must be presented with 3 digits after the decimal point.*/
using System; 

class URI {

    static void Main(string[] args) { 

        string[] l = Console.ReadLine().Split();
        double a = double.Parse(l[0]);
        double b = double.Parse(l[1]); 
        double c = double.Parse(l[2]); 

        Console.WriteLine($"TRIANGULO: {a*c/2:f3}");
        Console.WriteLine($"CIRCULO: {c*c*3.14159:f3}");
        Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:f3}");
        Console.WriteLine($"QUADRADO: {b*b:f3}");
        Console.WriteLine($"RETANGULO: {a*b:f3}");
        
    }

}