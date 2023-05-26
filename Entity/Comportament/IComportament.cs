namespace SAS.Entities;

public abstract class IComportament
{
    protected Shop shop = new Shop();
    public abstract Machine? GetBuy();
    public abstract bool Finished();
    public virtual void AttShop()
        => shop = new Shop();
    
}