using System.Text;
using Abstract_Classes_And_Interfaces.Products;
using Abstract_Classes_And_Interfaces.Interfaces;

namespace Abstract_Classes_And_Interfaces;

public class Program
{
    private delegate void MenuFunction();
    
    // Main program code:
    public static void Main(string[] args)
    {
        Dictionary<int, (string, MenuFunction)> menu = GetMenu();
        
        while (true)
        {
            // Printing out menu options:
            Console.WriteLine(TitleMarker("List out information of:"));
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}). {item.Value.Item1}");
            }
            
            // User input to choose option:
            Console.WriteLine("Enter your choice by typing in the option number:");
            string? userInput = Console.ReadLine();
            

            if (!int.TryParse(userInput, out int option)) //Checking input value
            {
                Console.WriteLine($"Invalid option. Please try again.");
                Console.WriteLine("Press enter for menu...");
                Console.ReadLine();
                continue;
            }
            if (!menu.ContainsKey(option)) // Checking if option is in menu
            {
                Console.WriteLine($"Option {option} is not in the menu. Please try again.");
                Console.WriteLine("Press enter for menu...");
                Console.ReadLine();
                continue;
            }

            if (menu[option].Item1 == "Exit") // Exit
            {
                Console.WriteLine("Exiting program. Bye!");
                break;
            }
                
            // Menu options with functions to invoke
            menu[option].Item2.Invoke();
            Console.WriteLine("Press enter for menu...");
            Console.ReadLine();
        }
    }
    
    private static Dictionary<int, (string, MenuFunction)> GetMenu()
    {
        // Getting all the products:
        List<Product> products = GetAllProducts();

        // Menu option <description, function>
        Dictionary<int, (string, MenuFunction)> menu = new Dictionary<int, (string, MenuFunction)>();
        menu.Add(1, ("All products", () => GetAllProductsInformation(products)));
        menu.Add(2, ("Bath room products", () => GetInterfaceProducts<IBathRoom>(products, "Bath Room Products")));
        menu.Add(3, ("Bed room products", () => GetInterfaceProducts<IBedRoom>(products, "Bed Room Products")));
        menu.Add(4, ("Kitchen products", () => GetInterfaceProducts<IKitchen>(products, "Kitchen Products")));
        menu.Add(5, ("Living room products", () => GetInterfaceProducts<ILivingRoom>(products, "Living Room Products")));
        menu.Add(6, ("Office products", () => GetInterfaceProducts<IOffice>(products, "Office Products")));
        menu.Add(7, ("All around products", () => GetInterfaceProducts<IAllAround>(products, "All Around Products")));
        menu.Add(8, ("Assemblable products", () => GetInterfaceProducts<IAssemblable>(products, "Assemblable Products")));
        menu.Add(9, ("Exit", null)!);

        return menu;
    }
    
    // Getting a list of all the products:

    private static List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        
        products.Add(new BabyCrib());
        products.Add(new ShowerCurtains());
        products.Add(new DiningTable());
        products.Add(new FlowerPot());
        products.Add(new FluffyBlanket());
        products.Add(new GamingChair());
        products.Add(new HeavyCurtains());
        products.Add(new KitchenCounter());
        products.Add(new OfficeDesk());
        products.Add(new QueensBed());
        products.Add(new Sofa());

        return products;
    }

    //Getting all products along with it's information:

    private static void GetAllProductsInformation(List<Product>products)
    {
        // Product information:
        StringBuilder productInformation = new StringBuilder();

        foreach (Product product in products)
        {
            productInformation.AppendLine(GetProductInformation(product));
        }
        Console.WriteLine(productInformation);
    }

    // Get a single product and it's information:

    private static string GetProductInformation(Product product)
    {
        StringBuilder productInformation = new StringBuilder();

        // Product information:
        productInformation.AppendLine($"{TitleMarker(product.ProductName())}:")
            .AppendLine($"- Price: {product.Price()}")
            .AppendLine($"- Description: {product.Description()}")
            .AppendLine($"- Shelf: {product.GetShelf()}");
    
        // Check for each interface and append if implemented
        if (product is IAssemblable assemblable)
            productInformation.AppendLine($"- {assemblable.Assemble()}");
        if (product is IBathRoom bathRoom)
            productInformation.AppendLine($"- {bathRoom.BathRoom()}");
        if (product is IBedRoom bedRoom)
            productInformation.AppendLine($"- {bedRoom.BedRoom()}");
        if (product is IKitchen kitchen)
            productInformation.AppendLine($"- {kitchen.Kitchen()}");
        if (product is ILivingRoom livingRoom)
            productInformation.AppendLine($"- {livingRoom.LivingRoom()}");
        if (product is IOffice office)
            productInformation.AppendLine($"- {office.Office()}");
        if (product is IAllAround allAround)
            productInformation.AppendLine($"- {allAround.AllAround()}");

        productInformation.AppendLine(); // Space
    
        return productInformation.ToString();
    }
    
    private static void GetInterfaceProducts<TInterface>(List<Product> products, string title)
    {
        StringBuilder interfaceProducts = new StringBuilder($"{TitleMarker(title)}:\n\n");
        foreach (var product in products)
        {
            if (product is TInterface)
            {
                interfaceProducts.AppendLine($"- {GetProductInformation(product)}");
            }
        }
        Console.WriteLine(interfaceProducts);
    }

    // A function to underline a title (product name and more):
    private static String TitleMarker(String product)
    {
        String title = $"{product.ToUpper()} \n";
        int length = product.Length;
        for (int i = 0; i < length; i++)
        {
            title += "-";
        }
        return title;
    }
}


