
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Silvertone King Trombone",
        Price = 4100.41M,
        ProductTypeId = 1
    },
     new Product()
    {
        Name = "Bach Stradivarius Trumpet ",
        Price = 3333.33M,
        ProductTypeId = 1
    },
     new Product()
    {
        Name = "Miraphone 186 CC Tuba",
        Price = 12062.41M,
        ProductTypeId = 1
    },
     new Product()
    {
        Name = "Stuff I've Been Feeling Lately",
        Price = 14.62M,
        ProductTypeId = 2
    },
     new Product()
    {
        Name = "Devotions: The Selected Poems of Mary Oliver",
        Price = 19.41M,
        ProductTypeId = 2
    },
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2
    }
};
//put your greeting here
string greeting = @"Welcome to Brass and Poem,
the Loudest Library on the Planet!";
Console.WriteLine(greeting);
//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
         DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products,productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products,productTypes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Smell Ya Later!");
    }
}

void DisplayMenu()
{
    Console.WriteLine(
    @"Choose an Option:
    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit");
   
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        var matchingType = productTypes.FirstOrDefault(pt => pt.Id == products[i].ProductTypeId);
        Console.WriteLine($"{i + 1}. {products[i].Name} costs ${products[i].Price} ({matchingType.Title})");
    }
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products,productTypes);
    Console.WriteLine("Select a Product to Delete:");
    string choice = Console.ReadLine();
    products.RemoveAt(int.Parse(choice) - 1);
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Product newProduct = new Product()
    {
        Name = null,
        Price = 0.00M,
        ProductTypeId = 0
    };
    Console.WriteLine("Enter Product Name:");
    newProduct.Name = Console.ReadLine();
    Console.WriteLine("Enter Product Price:");
    newProduct.Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine(@"Choose a Product Type:
    1. Brass
    2. Poem");
    newProduct.ProductTypeId = int.Parse(Console.ReadLine());
    products.Add(newProduct);

}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products,productTypes);
    Console.WriteLine("Choose as Product to Edit");
    int productChoice = int.Parse(Console.ReadLine());
    string choice = null;
    while ( choice != "0")
    {
        Console.WriteLine(@"Choose a Property to Edit:
        0. Done
        1. Name
        2. Price
        3. Product Type");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Enter a new Product Name:");
            products[productChoice - 1].Name = Console.ReadLine();
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter a New Price:");
            products[productChoice - 1].Price = decimal.Parse(Console.ReadLine());
        }
        else if (choice == "3")
        {
            Console.WriteLine(@"Select Category:
            1. Brass
            2. Poem");
            
            products[productChoice - 1].ProductTypeId = int.Parse(Console.ReadLine());

        }
    }
}

// don't move or change this!
public partial class Program { }