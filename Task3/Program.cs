var arraySize = Convert.ToInt32(Console.ReadLine());
int[] initialArray = new int[arraySize];
var inputString = Console.ReadLine();



initialArray = inputString
    .Split(" ")
    .Where(input => input != "")
    .Select(num => Convert.ToInt32(num))
    .Take(arraySize)
    .ToArray();

Dictionary<int, int> occurrence = new Dictionary<int, int> ();

for (int i = 0; i < initialArray.Length; i++)
{
    if (occurrence.ContainsKey(initialArray[i]))
    {
        occurrence[initialArray[i]]++;
    }
    else occurrence.Add(initialArray[i], 1);
}

foreach (var element in occurrence)
{
    Console.WriteLine($"{element.Key} appears {element.Value} times, sum {element.Key * element.Value}");
}