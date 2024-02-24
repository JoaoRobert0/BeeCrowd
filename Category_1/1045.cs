// beecrowd | 1045
// Triangle Types
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read 3 double numbers (A, B and C) representing the sides of a triangle and arrange them in decreasing order, so that the side A is the biggest of the three sides. Next, determine the type of triangle that they can make, based on the following cases always writing an appropriate message:

// if A ≥ B + C, write the message: NAO FORMA TRIANGULO
// if A2 = B2 + C2, write the message: TRIANGULO RETANGULO
// if A2 > B2 + C2, write the message: TRIANGULO OBTUSANGULO
// if A2 < B2 + C2, write the message: TRIANGULO ACUTANGULO
// if the three sides are the same size, write the message: TRIANGULO EQUILATERO
// if only two sides are the same and the third one is different, write the message: TRIANGULO ISOSCELES
// Input
// The input contains three double numbers, A (0 < A) , B (0 < B) and C (0 < C).

// Output
// Print all the classifications of the triangle presented in the input.
using System; 

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split();
        double[] list = new double[3];
        
        for (int i = 0; i < 3; i++){
            list[i] = double.Parse(line[i]);
        }
        
        for (int i = 1; i < 3; i++){
            double key = list[i];
            int j = i - 1;
            while (j >= 0 && key > list[j])
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
        
        if (list[0] >= list[1] + list[2]) Console.WriteLine("NAO FORMA TRIANGULO");
        else{
            if (list[0] * list[0] == list[1] * list[1] + list[2] * list[2])
                Console.WriteLine("TRIANGULO RETANGULO");
            if (list[0] * list[0] > list[1] * list[1] + list[2] * list[2])
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (list[0] * list[0] < list[1] * list[1] + list[2] * list[2])
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (list[0] == list[1] && list[0] == list[2])
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if (list[0] == list[1] || list[0] == list[2] || list[1] == list[2])
                Console.WriteLine("TRIANGULO ISOSCELES");
        }

    }

}