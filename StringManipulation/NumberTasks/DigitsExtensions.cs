namespace Extensions.NumberTasks;

public static class DigitsExtensions
{
    //Count sum of digits in the given number
    public static int SumOfDigits(this int number)
    {
        return SumOfDigits(number, 0);
    }

    //Find second largest int in a list

    private static int SumOfDigits(int number, int sum)
    {
        if (number < 1)
        {
            return sum;
        }

        var digit = number % 10;
        sum += digit;

        return SumOfDigits(number / 10, sum);
    }
}