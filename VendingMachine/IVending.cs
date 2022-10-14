using VendingMachine;
namespace VendingMachine
{

    public interface IVending
    {
        public void EmptyMachine() { }
        public void ShowMenu() { }
        public void StartMachine() { }
       
        public static void Purchase(Products machineProducts, Cash machineCash, Product product)
        {
            if (product.price <= machineCash.clientBalance)
            {
                machineProducts.RemoveProduct(product);
                machineCash.DecreaseClientBalance(product.price);
            }
            else
            {
                machineCash.ShowBalances();
                Console.WriteLine("Please Insert More Money");
            }
        }
        public static void ShowAll(Products machineProducts)
        {
            foreach (Product product in machineProducts.productsList)
            {
                Console.WriteLine($"{product.name}, {product.price}, {product.quantity}");
            }
        }
        public static void InsertMoney(Cash machineCash, int money)
        {
            if (Cash.ValidateInput(money))
                machineCash.IncreaseCash(money);
            else
                Cash.SpiteInput();
        }     
        public static void EndTransction(Cash machineCash)
        {
            machineCash.ReturnCash();
            Console.WriteLine("WELCOME");
        }

    }
}
