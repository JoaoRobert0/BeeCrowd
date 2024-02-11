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