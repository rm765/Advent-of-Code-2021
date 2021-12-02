var lines = File.ReadAllLines(@"input.txt").ToList();

int depth = 0;
int horizontal = 0;
int final;

//Part 1
foreach (var line in lines)
{
    var splitStr = line.Split(' ', 2);
    string direction = splitStr[0];
    int distance = int.Parse(splitStr[1]);
    if (direction == "up")
    {
        depth = depth + distance;
    }
    if (direction == "down")
    {
        depth = depth - distance;
    }
    if (direction == "forward")
    {
        horizontal = horizontal + distance;
    }


}
final = Math.Abs(horizontal * depth);
Console.WriteLine("Part 1: " + final);

//Part 2
int aim = 0;
depth = 0;
horizontal = 0;
foreach (var line in lines)
{
    var splitStr = line.Split(' ', 2);
    string direction = splitStr[0];
    int distance = int.Parse(splitStr[1]);
    if (direction == "up")
    {
        aim = aim + distance;
    }
    if (direction == "down")
    {
        aim = aim - distance;
    }
    if (direction == "forward")
    {
        horizontal = horizontal + distance;
        depth = depth + (aim * distance);
    }


}
final = Math.Abs(horizontal * depth);
Console.WriteLine("Part 2: " + final);
