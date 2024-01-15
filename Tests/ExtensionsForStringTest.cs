using Extensions.StringTasks;
using FluentAssertions;

namespace Tests;

public class ExtensionsForStringTests
{
    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.", ".did hannaH ?seeb ees hannaH diD")]
    public void Reverse_StringShouldBeReversed(string input, string reversedInput)
    {
        //Arrange //Act
        var result = input.Reverse();

        //Assert
        result.Should().Be(reversedInput);
    }

    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.", true)]
    public void IsPalindrome_ReturnsTrueOrFalse(string input, bool result)
    {
        //Arrange //Act
        var isPalindrome = input.IsPalindrome();

        //Assert
        isPalindrome.Should().Be(result);
    }

    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.", "did. Hannah bees? see Hannah Did")]
    public void ReverseTheWordsOrder_ReturnsReversedWords(string input, string result)
    {
        //Arrange //Act
        var reveredOrder = input.ReverseTheWordsOrder();

        //Assert
        reveredOrder.Should().Be(result);
    }

    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.", "diD hannaH ees ?seeb hannaH .did")]
    public void ReverseEachWordInSentence_EachWordInSentenceShouldBeReversed(string input, string result)
    {
        //Arrange //Act
        var reveredOrder = input.ReverseEachWordInSentence();

        //Assert
        reveredOrder.Should().Be(result);
    }

    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.", "Did Hanhseb?.")]
    public void RemoveDuplicates_ShouldReturnSentenceWithoutDuplicates(string input, string result)
    {
        //Arrange //Act
        var reveredOrder = input.RemoveDuplicateCharacters();

        //Assert
        reveredOrder.Should().Be(result);
    }

    [Theory]
    [InlineData("Did Hannah see bees? Hannah did.")]
    public void OccurrenceOfLetters_ReturnsDictionaryContainingOccurrenceOfEveryLetter(string input)
    {
        //Arrange
        var resultDictionary = new Dictionary<char, int>()
        {
            {'H', 2},
            {'a', 4},
            {'n', 4},
            {'h', 2},
            {'s', 2},
            {'e', 4},
            {'b', 1},
            {'?', 1},
            {'.', 1},
            {'D', 1},
            {'i', 2},
            {'d', 3},
            {' ', 5}
        };

        //Act
        var reveredOrder = input.OccurrenceOfLetters();

        //Assert
        reveredOrder.Should().Equal(resultDictionary);
    }
}