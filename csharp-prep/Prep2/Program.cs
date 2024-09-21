using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your grade porcentage");
        string LetterGrade = Console.ReadLine();

        int LetterValue = int.Parse(LetterGrade);
        string Letter = "";


        if (LetterValue >= 90)
        {
            Letter = "A";
        }
        else if (LetterValue >= 80)
        {
            Letter = "B";
        }
        else if (LetterValue >= 70 && LetterValue < 80)
        {
            Letter = "C";
        }
        else if (LetterValue >= 60 && LetterValue < 70)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }
        Console.WriteLine($"your grade is {Letter}.");

    }
}