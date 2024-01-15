namespace Extensions.NumberTasks;

public static class PrimeNumber
{
    //Check every number from 2 to n to find out if the given number is prime
    public static bool IsPrimeRecursive(int number)
    {
        return IsPrimeRecursive(number, 2);
    }

    //Check in more optimized way
    public static bool IsPrimeOptimized(int number)
    {
        if (number <= 1) return false;

        if (number == 2 || number == 3) return true;

        if (number % 2 == 0 || number % 3 == 0) return false;

        for (var i = 1; i <= Math.Sqrt(number); ++i) //because prime can be written as 6n+1, 6n-1
        {
            if (number % (6*i - 1) == 0 || number % (6*i + 1) == 0)
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsPrimeRecursive(int number, int temp)
    {
        if (number <= 1) return false;

        if (number == temp) return true;

        if (number % temp == 0) return false;

        return IsPrimeRecursive(number, ++temp);
    }
}