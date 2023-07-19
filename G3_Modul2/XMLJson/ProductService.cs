using Newtonsoft.Json;

namespace G3_Modul2.XMLJson;

public class ProductService
{
    public readonly string path;
    public ProductService(string FilePath)
    {
        path = FilePath;//"../../../DB.json";
    }

    public void UpdateProduct()
    {
        Product updatedProduct = SelectSingleProductFromFile(out List<Product>? products, "Input Deleted Product Id:");

        int index = products.IndexOf(updatedProduct);

        Console.WriteLine("Input Product new Name:");
        updatedProduct.Name = Console.ReadLine();

        Console.WriteLine("Input Product new Price:");
        updatedProduct.Price = float.Parse(Console.ReadLine());

        products[index] = updatedProduct;

        File.WriteAllText(path, JsonConvert.SerializeObject(products, Formatting.Indented));
    }

    public void DeleteProduct()
    {
        Product removedProduct = SelectSingleProductFromFile(out List<Product>? products, "Input Deleted Product Id:");


        products.Remove(removedProduct);

        File.WriteAllText(path, JsonConvert.SerializeObject(products, Formatting.Indented));
    }

    public Product SelectSingleProductFromFile(out List<Product>? products, string ConsoleText)
    {
        products = ReadProducts();
        Console.WriteLine(ConsoleText);
        Guid id = Guid.Parse(Console.ReadLine());
        return products.Single(p => p.Id == id);
    }

    public List<Product>? ReadProducts()
    {
        string jsontext = File.ReadAllText(path);
        List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(jsontext);
        products.ForEach(x => Console.WriteLine(x));
        return products;
    }

    public void CreateProduct()
    {
        bool isCreate = true;
        List<Product>? products = new();

        if (File.Exists(path))
            products = ReadProducts();

        while (isCreate)
        {
            Product product = new();
            product.Id = Guid.NewGuid();
            Console.WriteLine("Input Product Name:");
            product.Name = Console.ReadLine();

            Console.WriteLine("Input Product Price:");
            product.Price = float.Parse(Console.ReadLine());
            products.Add(product);
            Console.WriteLine("Do you want to continue ? Y or N");

            isCreate = Console.ReadLine() == "Y" ? true : false;
        }
        File.WriteAllText(path, JsonConvert.SerializeObject(products));
    }
}
