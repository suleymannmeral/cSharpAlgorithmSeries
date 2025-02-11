//Write a C# program that returns the elements of a given integer array in the opposite direction

using Algorithm8;

Console.Write("Please enter a array seperated by comma , :  ");
string input  = Console.ReadLine();

int[] array = input.Split(',').Select(int.Parse).ToArray();

int[] result = ClassAlgoritma8.Rotate(array);

foreach (int i in result)
{
    Console.Write(i);
    Console.Write(",");
}