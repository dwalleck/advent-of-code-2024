using System.Text.RegularExpressions;

// Claude's cleanup. I need to think more in Linq
var (total, enabledTotal) = MultiplierCalculator.Calculate("input.txt");
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Enabled Total: {enabledTotal}");

public class MultiplierCalculator
{
    private const string MultiplyPattern = @"mul\((\d{1,3}),(\d{1,3})\)";
    private const string DisablePattern = @"don't\(\).*?do\(\)";

    public static (int total, int enabledTotal) Calculate(string filePath)
    {
        var text = File.ReadAllText(filePath).ReplaceLineEndings("");
        var textWithHeader = string.Join("", File.ReadLines(filePath).Prepend("do()"));

        return (
            CalculateTotal(text),
            CalculateEnabledTotal(textWithHeader)
        );
    }

    private static int CalculateTotal(string text) =>
        Regex.Matches(text, MultiplyPattern)
            .Sum(GetProduct);

    private static int CalculateEnabledTotal(string text) =>
        Regex.Matches(
            Regex.Replace(text, DisablePattern, ""),
            MultiplyPattern
        ).Sum(GetProduct);

    private static int GetProduct(Match match) =>
        int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
}


// Original code. It works, but doesn't take advantage of all C# features
// var path = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
// var text = File.ReadAllText(path).Replace("\r\n", "")
//                                 .Replace("\n", "")
//                                 .Replace("\r", "");

// string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";

// var total = 0;

// var matches = Regex.Matches(text, pattern);

// foreach (Match match in matches)
// {
//     total += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
// }

// Console.WriteLine(total);


// var textLines = string.Join("", File.ReadLines(path).Prepend("do()"));

// var dontRemoved = Regex.Replace(textLines, @"don't\(\).*?do\(\)", "");
// var enabledTotal = 0;

// var enabledMatches = Regex.Matches(dontRemoved, pattern);

// foreach (Match match in enabledMatches)
// {
//     enabledTotal += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
// }

// Console.WriteLine(enabledTotal);



