using _6LetterWordChallenge.Interfaces;
using _6LetterWordChallenge.Models;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        IFileReader _fileReader = new FileReader();
        ICombinationFinder _combinationFinder = new CombinationFinder();
        string relativePath = "input.txt";

        string[] allLines = _fileReader.GetLinesFromFile(relativePath);


        foreach (string word in _combinationFinder.FindLetterCombinations(allLines,6))
        {
            Console.WriteLine(word);
        }
    }
}