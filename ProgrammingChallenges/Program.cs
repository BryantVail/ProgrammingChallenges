// See https://aka.ms/new-console-template for more information



// Specification
// given a string with a  length of 2, index 1 == index 0 after reversing string
// 

using StringManagement;

string value = Console.ReadLine();
Console.WriteLine($"User Input:\t{value}");

Console.WriteLine(
    $"Reversed Input\t" +
    $"{StringManipulator.ReverseString(value)}");

Console.ReadLine();














