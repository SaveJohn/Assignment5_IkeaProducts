using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces.Products;

public class ShowerCurtains: Product, IBathRoom
{
    public ShowerCurtains() 
        : base("shower curtains", 359.00f, "123.222.01", "Simple shower curtains with micro fibre material.")
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
    
    public string BathRoom()
    {
        return "Perfect curtains to keep the water away from your bathroom floor!";
    }
    
}