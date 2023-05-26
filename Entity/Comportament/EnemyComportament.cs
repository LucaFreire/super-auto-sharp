namespace SAS.Entities;

public class EnemyComportament : IComportament
{
    private int firstRound = 0;

    public override bool Finished()
    {
        if (firstRound < 3)
            return false;
        return true;
    }

    public override Machine GetBuy()
    {
        if (firstRound < 3)
        {
            firstRound++;
            return shop.Stock.First();
        }

        return null;
    }
}