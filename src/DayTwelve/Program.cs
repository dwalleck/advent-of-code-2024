string[] lines = File.ReadAllLines("input.txt");
Dictionary<(int, int), Plant> plants = [];

for (int i = 0; i < lines.Length; i++)
    for (int j = 0; j < lines[i].Length; j++)
        plants[(i, j)] = new Plant(lines[i][j]);

Queue<(int, int)> queue = new();

queue.Enqueue((0, 0));
List<int> gardens = new();

while (queue.Count is > 0)
{
    var (x, y) = queue.Dequeue();
    plants[(x, y)].Visited = true;
}


class Plant()
{
    public char Value { get; set; }
    public bool Visited { get; set; } = false;
    public int? Garden { get; set; } = null;
}

