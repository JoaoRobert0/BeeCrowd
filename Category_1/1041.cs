// beecrowd | 1041
// Coordinates of a Point
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Write an algorithm that reads two floating values (x and y), which should represent the coordinates of a point in a plane. Next, determine which quadrant the point belongs, or if you are at one of the Cartesian axes or the origin (x = y = 0).



// If the point is at the origin, write the message "Origem".

// If the point is at X axis write "Eixo X", else if the point is at Y axis write "Eixo Y".

// Input
// The input contains the coordinates of a point.

// Output
// The output should display the quadrant in which the point is.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] l = Console.ReadLine().Split();
        double x = double.Parse(l[0]);
        double y = double.Parse(l[1]);
        
        if (x == 0 && y == 0){
            Console.WriteLine("Origem");
        }
        else if (y == 0 && x != 0){
            Console.WriteLine("Eixo X");
        }
        else if (x == 0 && y != 0){
            Console.WriteLine("Eixo Y");
        }
        else if (x > 0){
            if (y > 0){
                Console.WriteLine("Q1");
            }
            else{
                Console.WriteLine("Q4");
            }
        }
        else if (x < 0){
            if (y > 0){
                Console.WriteLine("Q2");
            }
            else{
                Console.WriteLine("Q3");
            }
        }

    }

}