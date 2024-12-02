
// Cleaned up
// Claude's cleanup: much easier to read
var path = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
var numbers = File.ReadLines(path)
   .Select(line => line.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries))
   .Where(values => values.Length == 2)
   .Select(values => (
       First: int.Parse(values[0]),
       Second: int.Parse(values[1])
   ))
   .ToList();

var firstSum = numbers
   .OrderBy(x => x.First)
   .Zip(numbers.OrderBy(x => x.Second))
   .Sum(pair => Math.Abs(pair.First.First - pair.Second.Second));

Console.WriteLine(firstSum);

var secondSum = numbers
   .Select(x => x.Second)
   .Where(x => numbers.Any(n => n.First == x))
   .Sum();

Console.WriteLine(secondSum);


// Original
// var lines = File.ReadAllLines($"{Directory.GetCurrentDirectory()}\\input.txt");
// var columnOne = new List<int>();
// var columnTwo = new List<int>();

// foreach (var line in lines)
// {
//     var values = line.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
//     if (values.Length == 2)
//     {
//         columnOne.Add(int.Parse(values[0]));
//         columnTwo.Add(int.Parse(values[1]));
//     }
// }

// columnOne.Sort();
// columnTwo.Sort();
// var sum = 0;

// for (var i = 0; i < columnOne.Count; i++)
// {
//     var difference = Math.Abs(columnOne[i] - columnTwo[i]);
//     sum += difference;
// }

// var uniqueColumnOne = columnOne.ToDictionary(key => key, value => 0);
// foreach (var columnTwoValue in columnTwo)
// {
//     if (uniqueColumnOne.ContainsKey(columnTwoValue))
//     {
//         uniqueColumnOne[columnTwoValue] += columnTwoValue;
//     }

// }

// var secondSum = uniqueColumnOne.Values.Sum();
// Console.WriteLine(secondSum);



