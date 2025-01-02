var q = "*";
int i = 1;
while (true)
{
    while (i == 1)
    {
        Console.WriteLine(q);
        i++;
    }   
    while (i == 2)
    { 
        q = "**";
        Console.WriteLine(q);
        i++;
    }
    while (i == 3)
    {
        q = "***";
        Console.WriteLine(q);
        i++;
    }
    while (i == 4)
    {
        q = "****";
        Console.WriteLine(q);
        i++;
    }
    if (i == 5)
    {
        break;
    }
};
Console.ReadKey();  