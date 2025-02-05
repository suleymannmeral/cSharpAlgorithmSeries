using System;
using algorithmCSharp_5_;




Class1 obj = new Class1();



Console.Write("Enter two numbers separated by space: ");          

string input=Console.ReadLine();

string[] array = input.Split(' ');

int num1 = int.Parse(array[0]); 
int num2 = int.Parse(array[1]);

Console.Write(obj.Algorithm(num1, num2));


