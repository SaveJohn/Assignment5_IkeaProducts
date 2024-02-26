using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces.Products;

public class GamingChair: Product, IOffice, ILivingRoom, IBedRoom, IAssemblable
{
    public GamingChair() 
        : base("gaming chair", 1999.99f, "901.032.14", 
            "A comfortable gaming chair that allows for hours of gaming due to great ergonomics.")
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

    public string Office()
    {
        return $"This {productName} would be perfect for your work/game station in your office.";
    }

    public string LivingRoom()
    {
        return $"If you prefer to work or game somewhere more social, the {productName} surly be used `n" +
               $"   in a living room area.";
    }

    public string BedRoom()
    {
        return $"If you lack a private space such as an office, the bedroom would be a natural choice for your \n" +
               $"   {productName}.";
    }

    public string Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}