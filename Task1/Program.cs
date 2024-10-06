var n = Convert.ToInt32(Console.ReadLine());
int[] initialArray= new int[n];
int[] oddArray;
int[] evenArray;
var inputString = Console.ReadLine();



initialArray = inputString
    .Split(" ")
    .Where(input => input != "")
    .Select( num => Convert.ToInt32(num))
    .Take(n)
    .ToArray();

int oddCounter = 0;
int evenCounter = 0;
for (int i = 0; i < initialArray.Length; i++)
{ 
    if (initialArray[i] % 2 == 1) oddCounter++;
    else evenCounter++;
}

oddArray = new int [oddCounter];
evenArray = new int [evenCounter];

int oddArrayIndex = 0;
int evenArrayIndex = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i] % 2 == 1)
    {
        oddArray[oddArrayIndex] = initialArray[i];
        oddArrayIndex++;
    }
    else {
        evenArray[evenArrayIndex] = initialArray[i];
        evenArrayIndex++;
    }
}

Console.Write("Array #2 ");
for (int i = 0; i < evenArray.Length; i++)
{
    Console.Write(evenArray[i] + " ");
}
Console.WriteLine();

Console.Write("Array #1 ");
for (int i = 0; i < oddArray.Length; i++) Console.Write(oddArray[i] + " ");








