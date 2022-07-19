Console.WriteLine("Welcome to snake ladder game");
int Count = 0;
int Start = 0;
while (Start < 101)
{
    Random Dice = new Random();
    int dice = Dice.Next(1, 7);
    int game = Dice.Next(0, 3);
    //no play condition
    if (game == 0)
    {
        if (Start > 100)
        {
            Start = Start;
        }
        Count++;
    }
    //Snake condition
    else if (game == 1)
    {
        Start -= dice;
        if (Start < 0)
        {
            Start = 0;
        }
        else if (Start > 100)
        {
            Start = Start;
        }
        Count++;
    }
    //ladder condition
    else if (game == 2)
    {
        Console.WriteLine("play condition");
        
        Count++;
        if (Start > 100)
        {
            Start = Start;
        }
    }
    //saving all the counts in array
    int[] chance = { Count };

}
Console.WriteLine($"It takes {Count} times to reach END point in Snake Ladder Game");


