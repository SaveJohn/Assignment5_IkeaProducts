using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces.Products;

public class FlowerPot: Product, IAllAround
{
    public FlowerPot() 
        : base("flower pot", 169.99f, "333.451.32", "A nice flower pot in porcelain.")
    {
    }
    
    public override String ProductName()
    {
        return productName;
    }

    public override float Price()
    {
        return price;
    }

    public override string GetShelf()
    {
        return shelfNumber;
    }

    public override string Description()
    {
        return description;
    }

    public string AllAround()
    {
        return $"This {productName} would do nicely any where in your home. If you have a living plant in it, you \n" +
               $"   do wisely to place it somewhere with natural sun light";
    }
}