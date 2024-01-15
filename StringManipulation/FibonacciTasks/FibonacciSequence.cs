namespace Extensions.FibonacciTasks;

public static class FibonacciSequence
{
    //Creates a list of 'n' Fibonacci numbers. 
    //If the given n is incorrect, it returns empty list
    public static ICollection<int> CreateFibonacciSequence(int n)
    {
        return n > 0 ? CreateFibonacciSequence(0, 1, n, new List<int>()) : new List<int>();
    }

    private static ICollection<int> CreateFibonacciSequence(int a, int b, int n, ICollection<int> output)
    {
        if (n == 0) return output;

        output.Add(a);
        return CreateFibonacciSequence(b, a + b, --n, output);
    }
}