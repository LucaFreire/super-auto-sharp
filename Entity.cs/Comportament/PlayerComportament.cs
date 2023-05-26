namespace SAS.Entities;

public class PlayerComportament : IComportament
{
    public void ShopTurn()
    {
        string input;
        do
        {
            Shop shop = new Shop();
            System.Console.WriteLine("Shopping: ");
            

            input = Console.ReadLine();
        } while (input != "");
    }
}