using Extensions.FibonacciTasks;
using Extensions.NumberTasks;
using FluentAssertions;

namespace Tests;

public class ExtensionsForNumbersTests
{
    [Theory]
    [InlineData(17, true)]
    [InlineData(8, false)]
    [InlineData(3, true)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    public void IsPrimeRecursive_ShouldReturnTrueOrFalse(int number, bool isPrime)
    {
        //Arrange //Act
        var result = PrimeNumber.IsPrimeRecursive(number);

        //Assert
        result.Should().Be(isPrime);
    }

    [Theory]
    [InlineData(17, true)]
    [InlineData(8, false)]
    [InlineData(3, true)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    public void IsPrimeOptimized_ShouldReturnTrueOrFalse(int number, bool isPrime)
    {
        //Arrange //Act
        var result = PrimeNumber.IsPrimeOptimized(number);

        //Assert
        result.Should().Be(isPrime);
    }

    [Theory]
    [InlineData(234, 9)]
    [InlineData(1, 1)]
    [InlineData(0, 0)]
    [InlineData(-2222, 8)]
    public void SumOfDigits_ShouldReturnSumOfDigits(int number, int sumOfDigits)
    {
        //Arrange //Act
        var result = number.SumOfDigits();

        //Assert
        result.Should().Be(sumOfDigits);
    }

    [Theory]
    [InlineData(8, new[] { 0, 1, 1, 2, 3, 5, 8, 13 })]
    [InlineData(1, new[] { 0 })]
    [InlineData(-1, new int[] { })]
    public void FibonacciSequence_ShouldReturnListOfFibonacciNumbers(int lengthOfSequence, int[] output)
    {
        //Arrange //Act
        var result = FibonacciSequence.CreateFibonacciSequence(lengthOfSequence);

        //Assert
        result.Should().Equal(output);
    }
}