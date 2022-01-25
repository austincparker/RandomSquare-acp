// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var rand = new Random();
/*
 * 1
var bytes = new byte[20];
rand.NextBytes(bytes);
Console.WriteLine("Twenty random byte values:");
foreach (byte byteValue in bytes)
    Console.Write("{0, 5}", byteValue);
Console.WriteLine();
 */

List<int> numList = new List<int>();

Console.WriteLine("Make the numbers");

for (int ctr = 0; ctr <= 5; ctr++)
    numList.Add(rand.Next(1, 10));
foreach (int i in numList)
    Console.WriteLine(i);

Console.WriteLine("Square the numbers");

IEnumerable<int> sampleNumbersSquared = numList.Select(number => number * number);
foreach (int j in sampleNumbersSquared)
    Console.WriteLine(j);

Console.WriteLine("Take out odd numbers");


var onlyEvens = sampleNumbersSquared.Where(n => n % 2 == 0);
foreach (int k in onlyEvens)
    Console.WriteLine(k);