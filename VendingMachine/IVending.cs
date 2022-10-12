using VendingMachine;
namespace VendingMachine
{
   
   public interface IVending
    {
        public static void ShowMenu()
        {
            Console.Write("Please enter your choice.");
        }
        public void Purchase(Product product)
        {
            if (product.price <= MachineMoney.clientBalance)
            {
                MachineProducts.RemoveProduct(product);
                MachineMoney.clientBalance -= product.price;
            }
            ShowMenu();
        }
        public void ShowAll()
        {
            ShowMenu();
        }
        public void InsertMoney()
        {
            Console.Write("Please Insert Money:");
            int money = int.Parse(Console.ReadLine()!);
            MachineMoney.IncreaseCash(money);
            ShowMenu();
        }     
        public void EndTransction()
        {
            MachineMoney.ReturnCash(MachineMoney.clientBalance);
            Console.WriteLine("Please come again");
        }
    }
}
