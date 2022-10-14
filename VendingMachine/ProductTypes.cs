namespace VendingMachine
{
    public abstract class Product
    {
        private string name;
        public string? info;
        public int price;
        public int quantity;

        public string Name { get; set; }

        public Product()
        {
            Name = name;
        }
        public void RemoveOne()
        {
            this.quantity -= 1;
        }
    }

    public class ProductA : Product
    {
        public ProductA(string name, string info, int price, int quantity): base()
        {
            Name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }
    public class ProductB : Product
    {
        public ProductB(string name, string info, int price, int quantity) : base()
        {
            Name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }         
    public class ProductC : Product
    {
        public ProductC(string name, string info, int price, int quantity) : base()
        {
            Name = name;
            this.info = info;
            this.quantity = quantity;
            this.price = price;
        }
    }
}


