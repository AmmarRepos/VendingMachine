namespace VendingMachine
{
    public abstract class Product : IProductTypes
    {
        public string? name;
        public string? info;
        public int price;
        public int quantity;
    }
    
    public class ProductA : Product
    {
        public ProductA(string name, string info, int price, int quantity): base()
        {
            this.name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }
    public class ProductB : Product
    {
        public ProductB(string name, string info, int price, int quantity) : base()
        {
            this.name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }         
    public class ProductC : Product
    {
        public ProductC(string name, string info, int price, int quantity) : base()
        {
            this.name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }
}


