// Write a C# program to check the largest number among three given numbers   u can use math func
using LargestIntegersAmongThree;

Console.Write("Please enter 3 number seperated by , : ");
string input = Console.ReadLine();

string[] array = input.Split(',');

int num1 = int.Parse(array[0]);
int num2 = int.Parse(array[1]);
int num3 = int.Parse(array[2]);

Algorithm7 algorithm7 = new Algorithm7();
Console.Write(algorithm7.FindTheLargestNumber(num1, num2, num3));


