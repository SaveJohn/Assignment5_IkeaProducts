namespace Assignment5_IkeaProducts.Products;
public class BabyCrib: Product, IBedRoom, ILivingRoom, IAssemblable
{
    public BabyCrib()
    : base ("baby crib", 4699.99f, "703.767.21", "The perfect first bed for your new born.")
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

    public string BedRoom()
    {
        return $"The {productName} is the most essential furniture to your new born baby's bed room.";
    }

    public String LivingRoom()
    {
        return $"The {productName} may also be a great addition to your living room if you wish to keep your baby close \n " +
               $"during the baby's daytime naps.";
    }

    public String Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}