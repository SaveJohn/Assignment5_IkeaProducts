using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces.Products;

public class QueensBed: Product, IBedRoom, IAssemblable
{
    public QueensBed() 
        : base("queens bed", 6999.20f, "601.000.68", 
            "A comfortable queen sized bed, for \"couples\" and \"singles\" alike.")
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

    public string BedRoom()
    {
        return $"This {productName} is the perfect choice for your bedroom.";
    }
    public string Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}