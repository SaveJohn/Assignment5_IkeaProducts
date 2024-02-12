namespace Assignment5_IkeaProducts.Products;

public class Sofa: Product, ILivingRoom, IAssemblable
{
    public Sofa() 
        : base("sofa", 999f, "332.461.25", 
            "A simple and modest, yet comfortable, sofa")
    {
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
        return $"This {productName} is the perfect choice for a relaxing time in your living room.";
    }
    public string Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}