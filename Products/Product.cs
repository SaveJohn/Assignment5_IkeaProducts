namespace Abstract_Classes_And_Interfaces.Products;

public abstract class Product
{
    protected String productName;
    protected float price;
    protected String shelfNumber;
    protected String description;

    protected Product(string productName, float price, string shelfNumber, string description)
    {
        this.productName = productName;
        this.price = price;
        this.shelfNumber = shelfNumber;
        this.description = description;
    }

    public abstract String ProductName();

    public abstract float Price();

    public abstract String GetShelf();

    public abstract String Description();
    
}