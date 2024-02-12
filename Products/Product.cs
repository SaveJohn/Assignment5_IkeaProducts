namespace Assignment5_IkeaProducts.Products;

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

    public String ProductName
    {
        get { return productName; }
    }

    public abstract float Price();

    public abstract String GetShelf();

    public abstract String Description();

    /*

    public float? Price(float price)
    {
        try
        {
            if (price > 0)
            {
                productPrice = price;
                return productPrice;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine($"The price of {productName} does not seem to be set yet, please contact customer support! \n {e.Message}");
            return null;
        }

        throw new InvalidOperationException();
    }

    public String GetShelfNumber(String shelf)
    {
        try
        {
            shelfLocationNumber = shelf;
            return shelfLocationNumber;
        }
        catch (Exception e)
        {
            return
                $"There does not seem to be any shelf location number registered for this product \"{productName}\", please contact customer support. \n" +
                $"{e.Message}";
        }

    }


    public String Description(String description)
    {
        try
        {
            productDescription = description;
            return this.productDescription;
        }
        catch (Exception e)
        {
            return
                $"There is no description registered on \"{productName}\", please contact customer support for more info on the product. \n" +
                $"{e.Message}";
        }

    }
    */
}