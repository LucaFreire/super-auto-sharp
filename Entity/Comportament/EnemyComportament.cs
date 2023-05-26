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
            var buy = (shop.Stock.First());
            shop.RemoveFromStock(buy);
            return buy;
        }
        return null;
    }
}