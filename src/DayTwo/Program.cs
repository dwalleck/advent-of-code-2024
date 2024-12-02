var path = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
var lines = File.ReadLines(path)
    .Select(line => line.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse))
    .ToArray();


// cleaned up version
var safeReports = lines.Count(sequence =>
{
    var line = sequence.ToArray();
    var sign = Math.Sign(line[0] - line[1]);
    return Enumerable.Range(0, line.Length - 1)
        .Select(i =>
        {
            var diff = line[i] - line[i + 1];
            return Math.Sign(diff) == sign && Math.Abs(diff) is > 0 and <= 3;
        })
        .All(x => x);
});
Console.WriteLine(safeReports);


// var path = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
// var lines = File.ReadLines(path)
//    .Select(line => line.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse));

// var safeReports = 0;
// foreach (var line in lines)
// {
//     var lineArr = line.ToArray();
//     int sign = Math.Sign(lineArr[0].CompareTo(lineArr[1]));
//     var validPairs = new List<bool>();
//     for (int i = 0; i < lineArr.Length - 1; i++)
//     {
//         int diff = lineArr[i] - lineArr[i + 1];
//         int currentSign = Math.Sign(diff);
//         int absDiff = Math.Abs(diff);
//         validPairs.Add(currentSign == sign && 0 < absDiff && absDiff <= 3);
//     }
//     if (validPairs.TrueForAll(x => x))
//     {
//         safeReports++;
//     }

// }

// Console.WriteLine(safeReports);