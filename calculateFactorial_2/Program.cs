
while (true)
{
    Console.Write("Please Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());

    int factorial = 1;

    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;

    }


    Console.WriteLine("Factorial value is : " + factorial);

    Console.Write("Do u want to try again : (1/0)");
    int reply = Convert.ToInt32(Console.ReadLine());

    if(reply == 0)
    {
        Console.Write("Exit..");
        break;
    }


}

