namespace Extensions.Tasks;

internal static class DictionaryExtensions
{
    public static string PresentDictionary(this IDictionary<char, int> dictionary, string keyLabel, string valueLabel)
    {
        var outputStr = string.Empty;
        foreach (var pair in dictionary)
        {
            outputStr += keyLabel + ": " + pair.Key + "; " + valueLabel + ": " + pair.Value;
            outputStr += Environment.NewLine;
        }

        return outputStr;
    }
}