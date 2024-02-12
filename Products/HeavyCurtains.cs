namespace Assignment5_IkeaProducts.Products;

public class HeavyCurtains: Product, ILivingRoom, IBedRoom, IOffice
{
    public HeavyCurtains() 
        : base("heavy curtains", 489f, "021.522.09", 
            "Heavy curtains that will block out the strong sunlight.")
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
        return $"The {productName} would be perfect for your office, to imporve privacy and keep the sunlight off \n" +
               $"of your face and monitors.";
    }

    public string LivingRoom()
    {
        return $"The {productName} would be a great compiment in your living room space and help you see the \n" +
               $"picture on your TV without reflection of the sunlight.";
    }

    public string BedRoom()
    {
        return $"No place would fit these {productName} than your bed room, so you can block out the late  \n" +
               $"summer sun as you try to sleep.";
    }
}