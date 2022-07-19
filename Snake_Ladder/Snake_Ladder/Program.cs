Console.WriteLine("Welcome to snake ladder game");
int Count = 0;
int Start = 0;
while (Start<100)
{
    Random Dice = new Random();
    int dice = Dice.Next(1, 7);
    int game=Dice.Next(0,3);
    //no play condition
    if (game == 0)
    {
        Count++;
    }
    //Snake condition
    else if (game == 1)
    {
        Start -= dice;
        if(Start < 0)
        {
            Start = 0;
        }
        else if (Start > 101)
        {
            Start -=dice;
        }
        Count++;
    }
    //ladder condition
    else if (game == 2)
    {
        switch (dice)
        {
            case 1:
                Start += 1;
                break;
            case 2:
                Start += 2;
                break;
            case 3:
                Start += 3;
                break;
            case 4:
                Start += 4;
                break;
            case 5:
                Start += 5;
                break;
            default:
                Start += 6;
                break;
        }
        if (Start > 100)
        {
            Start -= dice;
        }
        Count++;
    }
    //saving all the counts in array
    int[] chance = { Count };
    
}
Console.WriteLine($"It takes {Count} times to reach {Start} i.e., END point in Snake Ladder Game");


