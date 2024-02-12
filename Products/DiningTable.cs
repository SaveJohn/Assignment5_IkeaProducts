namespace Assignment5_IkeaProducts.Products;

public class DiningTable: Product, IKitchen, ILivingRoom, IAssemblable
{
    public DiningTable()
        : base ("Dining table", 3445.69f, "803.013.21", "Simple dining table with a round shape to make your " +
                                              "meals more social.")
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
    
    public string kitchen()
    {
        return $"The {productName} is the perfect table to for your kitchen.";
    }

    public String LivingRoom()
    {
        return $"The {productName} would be a great addition to your living room if you wish to eat in a more social area.";
    }

    public String Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}