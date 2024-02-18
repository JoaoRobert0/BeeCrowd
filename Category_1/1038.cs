// beecrowd | 1038
// Snack
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Using the following table, write a program that reads a code and the amount of an item. After, print the value to pay. This is a very simple program with the only intention of practice of selection commands.



// Input
// The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this item according to the above table.

// Output
// The output must be a message "Total: R$ " followed by the total value to be paid, with 2 digits after the decimal point.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split();
        int x = int.Parse(line[0]);
        int y = int.Parse(line[1]);
        switch (x){
            case 1:
                Console.WriteLine($"Total: R$ {y * 4.0:f2}");
                break;
            case 2:
                Console.WriteLine($"Total: R$ {y * 4.50:f2}");
                break;
            case 3:
                Console.WriteLine($"Total: R$ {y * 5.0:f2}");
                break;
            case 4:
                Console.WriteLine($"Total: R$ {y * 2.0:f2}");
                break;
            case 5:
                Console.WriteLine($"Total: R$ {y * 1.50:f2}");
                break;
        }

    }

}