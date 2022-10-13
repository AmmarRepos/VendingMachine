namespace VendingMachine
{
    public abstract class Product
    {
        public string? name;
        public string? info;
        public int price;
        public int quantity;
        public void RemoveOne()
        {
            this.quantity -= 1;
        }
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


