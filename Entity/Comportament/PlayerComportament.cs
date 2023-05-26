namespace SAS.Entities;

public class PlayerComportament : IComportament
{
    public override bool Finished()
    {
        string input = Console.ReadLine();
        if (input == "")
            return true;
        return false;
    }

    public override Machine GetBuy()
    {
        string input;
        System.Console.WriteLine("Shopping: ");
        
        this.shop.ShowStock();
        input = Console.ReadLine();
        var buy = shop.Stock.FirstOrDefault(e => e.Name.ToLower() == input.ToLower());
        System.Console.WriteLine("Comprado: " + buy);
        shop.RemoveFromStock(buy);
        return buy;
    }

}