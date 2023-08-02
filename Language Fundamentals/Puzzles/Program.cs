//Coin Flip
static string CoinFlip()
{
    Random rand = new Random();
    int generate = rand.Next(0,2);

    if(generate == 1) {
        return "Heads";
    }
    if(generate == 0) {
        return "Tails";
    }

    return "The coin hangs suspended in the air...";
}
Console.WriteLine(CoinFlip());


//Dice Roll









//Stat Roll









//Roll Until...









//Optional Bonus