namespace _6LetterWordChallenge.Tests;
using _6LetterWordChallenge.Interfaces;
using _6LetterWordChallenge.Models;


public class CombinationFinderTests
{
    [Fact]
    public void CombinationFinder_finds_unique_combination()
    {
        //arrange
        ICombinationFinder combinationFinder = new CombinationFinder();
        int lengthOfWord = 6;
        string[] words = ["dagger", "a", "d", "g", "e", "r"];

        //Act
        var result = combinationFinder.FindLetterCombinations(words, lengthOfWord);

        //Assert
        Assert.Single(result);
    }

    [Fact]
    public void CombinationFinder_finds_multiple_possible_combinations()
    {
        //arrange
        ICombinationFinder combinationFinder = new CombinationFinder();
        int lengthOfWord = 6;
        string[] words = ["dagger", "danger", "a", "d", "g", "e", "r", "n"];

        //Act
        var result = combinationFinder.FindLetterCombinations(words, lengthOfWord);

        //Assert
        Assert.Equal(2, result.Count());
    }

}