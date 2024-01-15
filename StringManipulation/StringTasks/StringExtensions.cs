namespace Extensions.StringTasks;

public static class StringExtensions
{
    //Reverse the given string (both words and their order)
    public static string Reverse(this string inputStr)
    {
        var outputStr = string.Empty;

        for (var i = 1; i <= inputStr.Length; ++i)
        {
            outputStr += inputStr[^i];
        }

        return outputStr;
    }

    //Check if the given string is a palindrome
    public static bool IsPalindrome(this string inputStr)
    {
        var i = 0;
        var j = inputStr.Length - 1;

        while (i < j)
        {
            while (CheckIfWhitespaceOrPunctuationMark(inputStr[i]))
            {
                ++i;
            }

            while (CheckIfWhitespaceOrPunctuationMark(inputStr[j]))
            {
                --j;
            }

            if (char.ToUpper(inputStr[i]) != char.ToUpper(inputStr[j]))
            {
                return false;
            }

            ++i; --j;
        }
        
        return true;
    }

    //Reverse the order of given words in a string input
    public static string ReverseTheWordsOrder(this string inputStr)
    {
        var separatedWords = inputStr.Split(' ');
        var listOfWords = new List<string>();

        for (var i = 1; i <= separatedWords.Length; ++i)
        {
            listOfWords.Add(separatedWords[^i]);
        }

        var outputStr = string.Join(" ", listOfWords);
        return outputStr;
    }

    //Reverse each word in the given string but order remains the same
    public static string ReverseEachWordInSentence(this string inputStr)
    {
        var separatedWords = inputStr.Split(' ');
        var listOfWords = separatedWords.Select(word => word.Reverse()).ToList();

        return string.Join(" ", listOfWords);
    }

    //Count occurrence of each letter in the given string
    public static IDictionary<char, int> OccurrenceOfLetters(this string inputStr)
    {
        var outputDictionary = new Dictionary<char, int>();

        foreach (var letter in inputStr)
        {
            if (outputDictionary.TryGetValue(letter, out var occurrence))
            {
                outputDictionary[letter] = ++occurrence;
            }
            else
            {
                outputDictionary.Add(letter, 1);
            }
        }

        return outputDictionary;
    }

    //Remove duplicated letters/signs from the given string
    public static string RemoveDuplicateCharacters(this string inputStr)
    {
        var outputStr = string.Empty;

        foreach (var letter in inputStr)
        {
            if (!outputStr.Contains(letter))
            {
                outputStr += letter;
            }
        }

        return outputStr;
    }

    //Find all substrings
    public static ICollection<string> FindAllPossibleWords(this string inputStr)
    {
        var outputListOfWords = new List<string>();

        for (var i = 0; i < inputStr.Length; ++i)
        {
            outputListOfWords.Add(inputStr[i].ToString());

            var innerWord = inputStr[i].ToString();
            for (var j = i; j < inputStr.Length; ++j)
            {
                if (inputStr[i] == inputStr[j]) continue;

                innerWord += inputStr[j];
                outputListOfWords.Add(innerWord);
            }
        }

        return outputListOfWords;
    }

    private static bool CheckIfWhitespaceOrPunctuationMark(char sign)
    {
        return char.IsPunctuation(sign) || char.IsWhiteSpace(sign);
    }
}