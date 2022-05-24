

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Support");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Training");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("SupportTraining");
    }
    else
    {
        Console.WriteLine(i);
    }
}