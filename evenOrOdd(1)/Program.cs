// Program to Check Whether the Entered Number is Even or Odd  (1)

while (true)
{
    Console.Write("Please Enter A Number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("Number Is Odd");
    }

    else
    {
        Console.WriteLine("Number Is Even");
    }

    Console.WriteLine("Do you Want Tou Try Again: (Y/N)");
    string reply = Console.ReadLine().ToLower();
    if(reply!="y")
    {
        Console.Write("Exit..");
        break;
    }

}


