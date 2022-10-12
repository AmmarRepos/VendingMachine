namespace VendingMachine
{
    public class MachineProducts
    {
        private static List<Product> products = new List<Product>();
        public static void FillMachine()
        {
            Product pA = new ProductA();
            Product pB = new ProductB();
            Product pC = new ProductC();
            AddProduct(pA, 10);
            AddProduct(pB, 10);
            AddProduct(pC, 10);
        }
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
