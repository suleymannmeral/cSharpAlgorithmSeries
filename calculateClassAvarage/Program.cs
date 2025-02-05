while (true)
{
    Console.Write("Please enter the size of Class: ");
    int size = int.Parse(Console.ReadLine());
    int[] studentArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Student({i + 1}): ");
        studentArray[i] = int.Parse(Console.ReadLine());

    }

    int sumExam = 0;

    foreach (int i in studentArray)
    {
        sumExam += i;

    }


    int avarage = sumExam / size;

    Console.WriteLine($"Avarage: {avarage}");

    Console.Write("Do you want to calcualte again : (y/n)");
    string reply = Console.ReadLine().ToLower();
    if (reply == "n")
    {
        Console.Write("Exit...");
        break;
    }

}
