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
}