namespace VendingMachine
{
    public class Products
    {
        public List<Product> productsList = new List<Product>();
        public void AddProduct(Product product, int quantity)
        {
            productsList.Add(product);
            product.quantity += quantity;
        }
        public void RemoveProduct(Product product)
        {
            product.RemoveOne();
            if (product.quantity == 0)
                productsList.Remove(product);
            Console.WriteLine($"\nPlease take your {product.Name}");
            Console.WriteLine($"{product.info}");
        }
    }
}
