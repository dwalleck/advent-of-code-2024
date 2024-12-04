var grid = string.Join("", File.ReadAllLines("input.txt"));

//Console.WriteLine($"7 - {grid[7]}, 9 - {grid[9]}, - 10007 {grid[10007]}, - 10008 {grid[10008]}, - 10009 {grid[10009]}");
// .Select(line => line.ToList())
// .ToList();

Console.WriteLine("Done");

// 7 + 1, 7 - 1, 7 + 10007, 7 + 10008, 7 + 10006
// int firstX = grid.IndexOf;
// bool IsXmas = grid[firstX + 1] == 'M' && grid[firstX + 2] == 'A' && grid[firstX + 3] == 'S';
// Console.WriteLine(IsXmas);

var xLocations = new List<int>();

for (int i = 0; i < grid.Length - 3; i++)
{
    if (grid[i] == 'X')
    {
        xLocations.Add(i);
    }
}

var xmasCount = 0;
foreach (int xLocation in xLocations)
{
    if (grid[xLocation + 1] == 'M' && grid[xLocation + 2] == 'A' && grid[xLocation + 3] == 'S')
    {
        xmasCount++;
    }

    if (xLocation > 3 && grid[xLocation - 1] == 'M' && grid[xLocation - 2] == 'A' && grid[xLocation - 3] == 'S')
    {
        xmasCount++;
    }
}

Console.WriteLine(xmasCount);


// 7, 8, 9, 10
// 7, 6, 5, 4




// void isNextLetter(int startingPosition, int currentPosition, int letterPosition)
// {
//     if (grid[currentPosition] == word[letterPosition])
//     {
//         isNextLetter(currentPosition + 1, letterPosition + 1);
//         isNextLetter(position - 1, letterPosition + 1);
//         isNextLetter(position + 10000, letterPosition + 1);
//         isNextLetter(position + 1, letterPosition + 1);
//     }
// }


class CharInGrid()
{
    public int North { get; set; }
    public int Northeast { get; set; }
    public int East { get; set; }
    public int Southeast { get; set; }
    public int South { get; set; }
    public int Southwest { get; set; }
    public int West { get; set; }
    public int Northwest { get; set; }
}
