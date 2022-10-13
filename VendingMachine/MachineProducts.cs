namespace VendingMachine
{
    public class MachineProducts
    {
        public static List<Product> products = new List<Product>();
        
        
        public static void AddProduct(Product product, int quantity)
        {
            products.Add(product);
            product.quantity += quantity;
        }
        public static void RemoveProduct(Product product)
        {
            product.quantity -= 1;
            Console.WriteLine($"Please take your {product.name}");
            Console.WriteLine($"{product.info}");
        }
    }
}
