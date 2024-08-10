using _6LetterWordChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Models
{
    public class FileReader : IFileReader
    {
        public string[] GetLinesFromFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
