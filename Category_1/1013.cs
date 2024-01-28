/*beecrowd | 1013
The Greatest
Adapted by Neilor Tonin, URI  Brazil

Timelimit: 1
Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:

Input
The input file contains 3 integer values.

Output
Print the greatest of these three values followed by a space and the message “eh o maior”.*/
using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] l = Console.ReadLine().Split();
        int maior = MaiorAB(int.Parse(l[2]), MaiorAB(int.Parse(l[0]), int.Parse(l[1])));
        Console.WriteLine($"{maior} eh o maior");
    }
    
    static int MaiorAB(int a, int b){
        if (a-b < 0){
            return (a+b+((a-b)*-1))/2;
        }
        return (a+b+a-b)/2;
    }

}