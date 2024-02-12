namespace Assignment5_IkeaProducts.Products;

public class KitchenCounter: Product, IKitchen, IAssemblable
{
    public KitchenCounter() 
        : base("wooden kitchen counter", 550f, "002.127.75", 
            "A stylish wooden kitchen counter")
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
        return $"This {productName} is the perfect choice to pimp up you kitchen space.";
    }
    public string Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }

    
}