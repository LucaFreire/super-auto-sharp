namespace SAS.Entities;

public class PlayerComportament : IComportament
{
    public override bool Finished()
    {
        Console.WriteLine("Pressione qualquer botão para entrar na loja ou enter para continuar:");
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
        Console.WriteLine("Escolha sua máquina: ");
        input = Console.ReadLine();
        var buy = shop.Stock.FirstOrDefault(e => e.Name.ToLower() == input.ToLower());
        System.Console.WriteLine("Comprado: " + buy);
        shop.RemoveFromStock(buy);
        return buy;
    }

}