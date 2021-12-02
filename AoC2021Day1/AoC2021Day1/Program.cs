List<int> lst = new List<int>();
foreach (string line in File.ReadAllLines(@"input.txt"))
    {
    lst.Add(int.Parse(line));
}

//Part 1
int increased = 0;
for (int i = 1; i < lst.Count; i++)
{
    if (lst[i] > lst[i-1])
    {
        increased++;
    }
}
Console.WriteLine(increased);

//Part 2
increased = 0;
int sumNew = 0;
int sumOld = lst[2] + lst[1] + lst[0];
for (int i = 3; i < lst.Count; i++)
{

    sumNew = lst[i] + lst[i - 1] + lst[i - 2];

    if (sumNew > sumOld)
    {
        increased++;
    }
    sumOld = sumNew;

}
Console.WriteLine(increased);