using VendingMachine;
namespace VendingMachine
{
    public interface IProductTypes
    {
        public void ProductInfo(Product product)
        {
            Console.WriteLine($"{product.name}, {product.price}");
            
        }
        public void ProductManual(Product product)
        {
            Console.WriteLine($"{product.info}");
        }
    }
}
