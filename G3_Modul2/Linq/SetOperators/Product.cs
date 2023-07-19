namespace G3_Modul2.Linq.SetOperators
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }

       
    }
    public enum Category
    {
        New,
        Old,
        Future
    }
}
