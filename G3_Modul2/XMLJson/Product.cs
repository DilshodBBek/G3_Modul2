namespace G3_Modul2.XMLJson;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public float Price { get; set; }

    public override string ToString()
    {
        return $"Id:{Id}, Name:{Name}, Price:{Price}";
    }
}
