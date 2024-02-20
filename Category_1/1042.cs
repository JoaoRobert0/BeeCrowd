// beecrowd | 1042
// Simple Sort
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read three integers and sort them in ascending order. After, print these values in ascending order, a blank line and then the values in the sequence as they were readed.

// Input
// The input contains three integer numbers.

// Output
// Present the output as requested above.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] l = Console.ReadLine().Split();
        int[] list = new int[3];
        
        for (int i = 0; i < 3; i++){
            list[i] = int.Parse(l[i]);
        }
        
        for (int i = 0; i < 3; i++){
            int min = i;
            for (int j = i + 1; j < 3; j++){
                if (list[min] > list[j]){
                    min = j;
                }
            }
            int aux = list[i];
            list[i] = list[min];
            list[min] = aux;
        }
        
        foreach (int i in list){
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        
        foreach (string i in l){
            Console.WriteLine(i);
        }
        
    }

}