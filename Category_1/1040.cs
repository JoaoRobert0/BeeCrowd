// beecrowd | 1040
// Average 3
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student. Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message "Media: " (Average), followed by the calculated result. If the average was 7.0 or more, print the message "Aluno aprovado." (Approved Student). If the average was less than 5.0, print the message: "Aluno reprovado." (Reproved Student). If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student).

// In case of exam, read one more score. Print the message "Nota do exame: " (Exam score) followed by the typed score. Recalculate the average (sum the exam score with the previous calculated average and divide by 2) and print the message “Aluno aprovado.” (Approved student) in case of average 5.0 or more) or "Aluno reprovado." (Reproved student) in case of average 4.9 or less. For these 2 cases (approved or reproved after the exam) print the message "Media final: " (Final average) followed by the final average for this student in the last line.

// Input
// The input contains four floating point numbers that represent the students' grades.

// Output
// Print all the answers with one digit after the decimal point.
using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] l = Console.ReadLine().Split();
        double n1 = double.Parse(l[0]);
        double n2 = double.Parse(l[1]);
        double n3 = double.Parse(l[2]);
        double n4 = double.Parse(l[3]);
        
        double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1)/ 10;
        media = Math.Round(media, 1);
        Console.WriteLine($"Media: {media:f1}");
        
        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double n5 =double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {n5:f1}");
            double mediaFn = (media + n5)/ 2;
            
            if (mediaFn >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {mediaFn:f1}");
        }

    }

}