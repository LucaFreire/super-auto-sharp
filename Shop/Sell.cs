namespace SAS;
public static class SellClass
{
    public static void Sell(this Player player, Machine machine)
        => player.Money += machine.GetValue(); 
}