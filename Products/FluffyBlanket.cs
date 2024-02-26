using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces.Products;

public class FluffyBlanket: Product, ILivingRoom, IBedRoom
{
    public FluffyBlanket() 
        : base("fluffy blanket", 99.80f, "101.002.55", "A very comfortable blanket.")
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

    public string LivingRoom()
    {
        return $"This {productName} will do well by your sofa in the living room area.";
    }

    public string BedRoom()
    {
        return $"If you want some extra comfort in your bed room, this {productName} will surly compliment your bed.";
    }
}