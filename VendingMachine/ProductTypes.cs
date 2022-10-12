namespace VendingMachine
{
    public abstract class Product : IProductTypes
    {
        public string name;
        public string info;
        public int price;
        public int quantity;
    }
    
    public class ProductA : Product
    {
    }
    public class ProductB : Product
    {

    }
    public class ProductC : Product
    {

    }
}


