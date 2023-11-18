/*

24 50 36 70
0
4
3
1
End

 */





int[] num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string input;
int shootedTarget = 0;
while ((input = Console.ReadLine()) != "End")
{
    int targetIndex = int.Parse(input);
    if (targetIndex < 0 || targetIndex >= num.Length)
    {
        continue;
    }

    int targetValue = num[targetIndex];

    if (num[targetIndex] == -1)
    {
        continue;
    }

    num[targetIndex] = -1;
    shootedTarget += 1;

    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] == -1)
        {
            continue;
        }
        else if (targetValue < num[i])
        {
            num[i] -= targetValue;
        }
        else if (targetValue >= num[i])
        {
            num[i] += targetValue;
        }
    }
}
Console.WriteLine($"Shot targets: {shootedTarget} -> {string.Join(" ", num)}");

