using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Assignment5_IkeaProducts.Products;

namespace Assignment5_IkeaProducts;

public class Program
{
    public delegate void MyFunction();
    
    // Main program code:
    public static void Main(string[] args)
    {
        Dictionary<int, (string, MyFunction)> menu = GetMenu();
        
        while (true)
        {
            // Printing out menu options:
            Console.WriteLine(titleMarker("List out information of:"));
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}). {item.Value.Item1}");
            }
            
            // User input to choose option:
            Console.WriteLine("Enter your choice by typing in the option number:");
            String userInput = Console.ReadLine();
            int option;

            if (int.TryParse(userInput, out option)) //Checking input value
            {
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
                
                // Menu options with functions to evoke
                menu[option].Item2.Invoke();
                Console.WriteLine("Press enter for menu...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Invalid option. Please try again.");
                Console.WriteLine("Press enter for menu...");
                Console.ReadLine();
            }
        }
    }
    
    private static Dictionary<int, (string, MyFunction)> GetMenu()
    {
        // Getting all the products:
        List<Product> products = GetAllProducts();

        // Menu option <description, function>
        Dictionary<int, (string, MyFunction)> menu = new Dictionary<int, (string, MyFunction)>();
        menu.Add(1, ("All products", () => GetProductsInformation(products)));
        menu.Add(2, ("Bath room products", () => GetBathRoomProducts(products)));
        menu.Add(3, ("Bed room products", () => GetBedRoomProducts(products)));
        menu.Add(4, ("Kitchen products", () => GetKitchenProducts(products)));
        menu.Add(5, ("Living room products", () => GetLivingRoomProducts(products)));
        menu.Add(6, ("Office products", () => GetOfficeProducts(products)));
        menu.Add(7, ("All around products", () => GetAllAroundProducts(products)));
        menu.Add(8, ("Exit", null));

        return menu;
    }
    
    // Getting a list of all the products:

    public static List<Product> GetAllProducts()
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

    public static void GetProductsInformation(List<Product>products)
    {
        // Product information:
        String productInformation = "";

        foreach (Product product in products)
        {

            // Product along with it's attributes:
            productInformation += $"{titleMarker(product.ProductName)}: \n" +
                                  $"- Price: {product.Price()} \n" +
                                  $"- Description: {product.Description()} \n" +
                                  $"- Shelf: {product.GetShelf()} \n";

            // Including interface attributes when they are relevant:
            if (product is IAssemblable) // Assemblable 
            {
                productInformation +=  $"- {((IAssemblable)product).Assemble()} \n";
            }

            if (product is IBathRoom) // Bath Room
            {
                productInformation += $"- {((IBathRoom)product).BathRoom()} \n";
            }

            if (product is IBedRoom) // Bed Room
            {
                productInformation += $"- {((IBedRoom)product).BedRoom()} \n";
            }

            if (product is IKitchen) // Kitchen
            {
                productInformation += $"- {((IKitchen)product).kitchen()} \n";
            }

            if (product is ILivingRoom) // Living Room
            {
                productInformation += $"- {((ILivingRoom)product).LivingRoom()} \n";
            }

            if (product is IOffice) // Office
            {
                productInformation += $"- {((IOffice)product).Office()} \n";
            }

            if (product is IAllAround) // All Around
            {
                productInformation += $"- {((IAllAround)product).AllAround()} \n";
            }
            
            productInformation += "\n";
        }
        Console.WriteLine(productInformation);
    }

    // Get a single product and it's information:

    public static string GetProductInformation(Product product)
    {
        // Product information:
        String productInformation = "";

        

        // Product along with it's attributes:
        productInformation += $"{titleMarker(product.ProductName)}: \n" +
                              $"- Price: {product.Price()} \n" +
                              $"- Description: {product.Description()} \n" +
                              $"- Shelf: {product.GetShelf()} \n";

        // Including interface attributes when they are relevant:
        if (product is IAssemblable) // Assemblable 
        {
            productInformation +=  $"- {((IAssemblable)product).Assemble()} \n";
        }

        if (product is IBathRoom) // Bath Room
        {
            productInformation += $"- {((IBathRoom)product).BathRoom()} \n";
        }

        if (product is IBedRoom) // Bed Room
        {
            productInformation += $"- {((IBedRoom)product).BedRoom()} \n";
        }

        if (product is IKitchen) // Kitchen
        {
            productInformation += $"- {((IKitchen)product).kitchen()} \n";
        }

        if (product is ILivingRoom) // Living Room
        {
            productInformation += $"- {((ILivingRoom)product).LivingRoom()} \n";
        }

        if (product is IOffice) // Office
        {
            productInformation += $"- {((IOffice)product).Office()} \n";
        }

        if (product is IAllAround) // All Around
        {
            productInformation += $"- {((IAllAround)product).AllAround()} \n";
        }
        
        productInformation += "\n";
        
        return productInformation;
    }

    // Getting all products connected to one of the following interfaces:
    // Assemblable

    public static void GetAssemblableProducts(List<Product>products)
    {
        String assemblableProducts = $"{titleMarker("Assemblable Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IAssemblable assemblableProduct)
            {
                assemblableProducts += $"- {GetProductInformation(product)}\n";
                
            }
        }
        Console.WriteLine(assemblableProducts);
    }

    public static void GetBathRoomProducts(List<Product>products)
    {
        String bathRoomProducts = $"{titleMarker("Bath Room Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IBathRoom bathRoomProduct)
            {
                bathRoomProducts += $"- {GetProductInformation(product)} \n";
            }
        }

        Console.WriteLine(bathRoomProducts);
    }

    public static void GetBedRoomProducts(List<Product>products)
    {
        String bedRoomProducts = $"{titleMarker("Bed Room Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IBedRoom bedRoomProduct)
            {
                bedRoomProducts += $"- {GetProductInformation(product)} \n";
            }
        }

        Console.WriteLine(bedRoomProducts);
    }

    public static void GetKitchenProducts(List<Product>products)
    {
        String kitchenProducts = $"{titleMarker("Kitchen Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IKitchen kitchenProduct)
            {
                kitchenProducts += $"- {GetProductInformation(product)} \n";
            }
        }

        Console.WriteLine(kitchenProducts);
    }

    public static void GetLivingRoomProducts(List<Product>products)
    {
        String livingRoomProducts = $"{titleMarker("Living Room Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is ILivingRoom livingRoomProduct)
            {
                livingRoomProducts += $"- {GetProductInformation(product)} \n";
            }
        }
        Console.WriteLine(livingRoomProducts);
    }


    public static void GetOfficeProducts(List<Product>products)
    {
        String officeProducts = $"{titleMarker("Office Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IOffice officeProduct)
            {
                officeProducts += $"- {GetProductInformation(product)} \n";
            }
        }
        Console.WriteLine(officeProducts);
    }

    public static void GetAllAroundProducts(List<Product> products)
    {
        String allAroundProducts = $"{titleMarker("All Around Products:")} \n \n";
        foreach (Product product in products)
        {
            if (product is IAllAround allAroundProduct)
            {
                allAroundProducts += $"- {GetProductInformation(product)} \n";
            }
        }
        Console.WriteLine(allAroundProducts);
    }

    // A function to underline a title (product name and more):

    public static String titleMarker(String product)
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


