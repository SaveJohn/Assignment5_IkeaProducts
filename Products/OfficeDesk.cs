namespace Assignment5_IkeaProducts.Products;

public class OfficeDesk: Product, IOffice, ILivingRoom, IBedRoom, IAssemblable
{
    public OfficeDesk() 
        : base("office desk", 1305.79f, "952.062.10", 
            "A basic desk for office purposes.")
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

    public string Office()
    {
        return $"This {productName} is just what you need in an office space.";
    }

    public string LivingRoom()
    {
        return $"If you prefer to work somewhere more social, the {productName} surly be used `n" +
               $"on a living room area.";
    }

    public string BedRoom()
    {
        return $"If you lack a private space such as an office, the bedroom would be a natural choice for your \n" +
               $"{productName}.";
    }

    public string Assemble()
    {
        return
            $"The {productName} comes with an Assembly instruction manual and must be assembled at home.";
    }
}