namespace VendingMachine
{
    public class Products
    {
        public List<Product> products = new List<Product>();
        public void AddProduct(Product product, int quantity)
        {
            products.Add(product);
            product.quantity += quantity;
        }
        public void RemoveProduct(Product product)
        {
            product.RemoveOne();
            if (product.quantity == 0)
                products.Remove(product);
            Console.WriteLine($"\nPlease take your {product.name}");
            Console.WriteLine($"{product.info}");
        }
    }
}
