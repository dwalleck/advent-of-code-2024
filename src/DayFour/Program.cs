var grid = File.ReadAllLines("input.txt")
    .Select(line => line.ToList())
    .ToList();

Console.WriteLine("Done");


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
