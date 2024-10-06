var arraySize = Convert.ToInt32(Console.ReadLine());
int[] initialArray = new int[arraySize];
var inputString = Console.ReadLine();



initialArray = inputString
    .Split(" ")
    .Where(input => input != "")
    .Select(num => Convert.ToInt32(num))
    .Take(arraySize)
    .ToArray();

Array.Sort(initialArray); ;

Console.WriteLine("How many top grades do you want to know");
int n = Convert.ToInt32(Console.ReadLine());
int starter = initialArray.Length-n;
for(int i = starter; i < initialArray.Length; i++)
{
    Console.WriteLine(initialArray[i]);
}
