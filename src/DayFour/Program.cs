using System.Numerics;

var grid = File.ReadAllLines("input.txt")
    .Select(line => line.ToList())
    .ToList();
// Given the starting character, the next letter needs to be (x + 1), (x - 1), (y + 1), (y + 1, x + 1), or (y + 1, x - 1)
var word = "XMAS";
var xmasCount = 0;
var letterCoordinates = new Dictionary<(int x, int y), char>();
var xCoordinates = new List<(int x, int y)>();

for (int y = 0; y < grid.Count; y++)
{
    for (int x = 0; x < grid[y].Count; x++)
    {
        if (grid[x][y] == 'X')
        {
            xCoordinates.Add((x, y));
        }
        else
        {
            letterCoordinates[(x, y)] = grid[x][y];
        }
    }
}

foreach (var xCoord in xCoordinates)
{
    if (letterCoordinates[(xCoord.x + 1, xCoord.y)] == 'M')
    {

    }
}

// What I want is a list of transformations I want to apply, then check all the transformations

// BigInteger i = 0;


// foreach (var letterX in letterCoordinates['X'])
// {
//     var m = new Coordinate
//     {
//         x = letterX.x - 1,
//         y = letterX.y
//     };
//     var a = new Coordinate
//     {
//         x = letterX.x - 2,
//         y = letterX.y
//     };
//     var s = new Coordinate
//     {
//         x = letterX.x - 3,
//         y = letterX.y
//     };
//     if (letterCoordinates['M'].Contains(m) && letterCoordinates['A'].Contains(a) && letterCoordinates['S'].Contains(s))
//     {
//         xmasCount++;
//     }
// }

Console.WriteLine(xmasCount);
Console.WriteLine("Done");

// for (int y = 0; y < grid.Count; y++)
// {
//     for (int x = 0; x < grid[y].Count; x++)
//     {
//         if (grid[x][y] == 'X')
//         {
//             // Try the different possibilities
//             if (x < grid[y].Count - 3)
//             {
//                 if (grid[x + 1][y] == 'M' && grid[x + 2][y] == 'A' && grid[x + 3][y] == 'S')
//                 {
//                     xmasCount++;
//                 }
//             }

//             if (x > 3)
//             {
//                 if (grid[x - 1][y] == 'M' && grid[x - 2][y] == 'A' && grid[x - 3][y] == 'S')
//                 {
//                     xmasCount++;
//                 }
//             }
//         }
//     }
// }




// 7 + 1, 7 - 1, 7 + 10007, 7 + 10008, 7 + 10006
// int firstX = grid.IndexOf;
// bool IsXmas = grid[firstX + 1] == 'M' && grid[firstX + 2] == 'A' && grid[firstX + 3] == 'S';
// Console.WriteLine(IsXmas);

// var xLocations = new List<int>();

// for (int i = 0; i < grid.Length - 3; i++)
// {
//     if (grid[i] == 'X')
//     {
//         xLocations.Add(i);
//     }
// }

// var xmasCount = 0;
// foreach (int xLocation in xLocations)
// {
//     if (grid[xLocation + 1] == 'M' && grid[xLocation + 2] == 'A' && grid[xLocation + 3] == 'S')
//     {
//         xmasCount++;
//     }

//     if (xLocation > 3 && grid[xLocation - 1] == 'M' && grid[xLocation - 2] == 'A' && grid[xLocation - 3] == 'S')
//     {
//         xmasCount++;
//     }
// }


record Coordinate()
{
    public int x { get; set; }
    public int y { get; set; }
};
