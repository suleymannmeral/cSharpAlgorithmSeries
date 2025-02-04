
Console.Write("Please enter a value of array size : ");

int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

for (int i=0; i<size;i++)                           
{
    Console.Write($"{i+1}. Number is  : ");
    array[i] = int.Parse(Console.ReadLine());        
}


int maxNumber= array[0];

foreach(int num in array)
{
    if(num>maxNumber)
    {
        maxNumber = num; 
    }
}
Console.Write("Max Number Is : " + maxNumber);
