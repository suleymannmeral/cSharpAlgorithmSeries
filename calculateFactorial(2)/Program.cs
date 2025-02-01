// A Program that calcualtes the factorial value of the entered number

Console.Write("Please enter a number : ");
int number= Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for(int i=1;i<=number;i++)
{
    factorial= factorial * i;
}

if(factorial==0)
{
    factorial = 1;
}

Console.Write("Factorial value is :"+factorial);









