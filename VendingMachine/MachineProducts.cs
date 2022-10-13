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
            product.RemoveOne();
            if (product.quantity == 0)
                products.Remove(product);
            Console.WriteLine($"Please take your {product.name}");
            Console.WriteLine($"{product.info}");
        }
    }
}
