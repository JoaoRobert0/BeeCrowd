/*beecrowd | 1004
Simple Product
Adapted by Neilor Tonin, URI  Brazil

Timelimit: 1
Read two integer values. After this, calculate the product between them and store the result in a variable named PROD. Print the result like the example below. Do not forget to print the end of line after the result, otherwise you will receive “Presentation Error”.

Input
The input file contains 2 integer numbers.

Output
Print the message "PROD" and PROD according to the following example, with a blank space before and after the equal signal.*/
using System; 

class URI {

    static void Main(string[] args) { 
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"PROD = {x * y}");
    }

}