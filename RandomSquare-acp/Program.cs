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

for (int ctr = 0; ctr <= 4; ctr++)
    numList.Add(rand.Next(50, 101));
foreach (int i in numList)
    Console.WriteLine(i);

IEnumerable<int> sampleNumbersSquared = numList.Select(number => number * number);
foreach (int j in sampleNumbersSquared)
    Console.WriteLine(j);