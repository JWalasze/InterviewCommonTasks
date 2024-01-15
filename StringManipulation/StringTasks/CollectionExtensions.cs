using System.Collections;

namespace Extensions.Tasks;

internal static class CollectionExtensions
{
    public static string PresentCollection(this ICollection<string> collection)
    {
        var outputStr = Environment.NewLine;

        foreach (var item in collection)
        {
            outputStr += item;
            outputStr += Environment.NewLine;
        }

        return outputStr;
    }
}