int[] arr = new int[0];
arr = arr.Append(1).ToArray();
arr = arr.Append(2).ToArray();
arr = arr.Append(3).ToArray();
arr = arr.Append(4).ToArray();

int sum = 0;
foreach (var item in arr)
{
    sum += item;
}

Console.WriteLine(sum);