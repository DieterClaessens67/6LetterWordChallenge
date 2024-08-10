namespace _6LetterWordChallenge.Tests;
using _6LetterWordChallenge.Interfaces;
using _6LetterWordChallenge.Models;

public class FileReaderTests
{
    [Fact]
    public void FileReader_gets_strings_from_file()
    {
        //arrange
        IFileReader fileReader = new FileReader();
        string file = "input.txt";

        //Act
        var result = fileReader.GetLinesFromFile(file);

        //Assert
        Assert.Equal(4202, result.Count());
    }
}

