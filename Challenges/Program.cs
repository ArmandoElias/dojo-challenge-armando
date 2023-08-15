// See https://aka.ms/new-console-template for more information
using Challenges;

//Console.WriteLine("Hello, World!");
var inputData = ")()())";
var result = LongestValidParentheses.FindLength(inputData);

Console.WriteLine($"the length of {inputData} is {result}");
Console.ReadKey();