using misaligned;
using System;

ColorPrinter consolePrinter = (n, major, minor) =>
	Console.WriteLine($"{n} | {major} | {minor}");

ColorPrinter testPrinter = (n, major, minor) =>
	Console.WriteLine($"[TEST] {n} - {major}/{minor}");

Console.WriteLine("Using console printer:");
int total = ColorMapper.Print(consolePrinter);
Console.WriteLine($"Total pairs = {total}\n");

Console.WriteLine("Using test printer:");
total = ColorMapper.Print(testPrinter);
Console.WriteLine($"Total pairs = {total}");