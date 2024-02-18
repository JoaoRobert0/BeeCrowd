// beecrowd | 1020
// Age in Days
// Adapted by Neilor Tonin, URI  Brazil

// Timelimit: 1
// Read an integer value corresponding to a person's age (in days) and print it in years, months and days, followed by its respective message “ano(s)”, “mes(es)”, “dia(s)”.

// Note: only to facilitate the calculation, consider the whole year with 365 days and 30 days every month. In the cases of test there will never be a situation that allows 12 months and some days, like 360, 363 or 364. This is just an exercise for the purpose of testing simple mathematical reasoning.

// Input
// The input file contains 1 integer value.

// Output
// Print the output, like the following example.
using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        int year = n/365;
        int month = (n%365)/30;
        int day = (n%365)%30;
        Console.WriteLine($"{year} ano(s)\n{month} mes(es)\n{day} dia(s)");

    }

}