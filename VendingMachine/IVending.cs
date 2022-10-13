using VendingMachine;
namespace VendingMachine
{
   
   public interface IVending
    {
        
        public static void ShowMenu()
        {
            Console.WriteLine("\nPlease enter your choice.");
            Console.WriteLine("1: Purchase Product A\n2: Show All\n");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.I:
                    InsertMoney();
                    ShowMenu();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    StartMachine();
                    ShowMenu();
                    break;
                case ConsoleKey.A:
                    Purchase(MachineProducts.products[0]);
                    ShowMenu();
                    break;
                case ConsoleKey.B:
                    Purchase(MachineProducts.products[1]);
                    ShowMenu();
                    break;
                case ConsoleKey.C:
                    Purchase(MachineProducts.products[2]);
                    ShowMenu();
                    break;
                case ConsoleKey.S:
                    ShowAll();
                    ShowMenu();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    EndTransction();
                    ShowMenu();
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.WriteLine("SHUTTING DOWN ...");
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }
        public static void Purchase(Product product)
        {
            if (product.price <= MachineMoney.clientBalance)
            {
                MachineProducts.RemoveProduct(product);
                MachineMoney.DecreaseClientBalance(product.price);
            }
        }
        public static void ShowAll()
        {
            foreach (Product product in MachineProducts.products)
            {
                Console.WriteLine($"{product.name}, {product.price}, {product.quantity}");
            }
        }
        public static void InsertMoney()
        {
            Console.Write("\nPlease Insert Money:");
            int money = int.Parse(Console.ReadLine()!);
            MachineMoney.IncreaseCash(money);
        }     
        public static void EndTransction()
        {
            MachineMoney.ReturnCash(MachineMoney.clientBalance);
            Console.WriteLine("WELCOME");
        }
        public static void StartMachine()
        {
            MachineMoney.clientBalance = 0;
            MachineMoney.machineBalance = 0;
            Product pA = new ProductA("product a", "info a", 10, 0);
            MachineProducts.AddProduct(pA, 10);
            Product pB = new ProductB("product b", "info b", 100, 0);
            MachineProducts.AddProduct(pB, 20);
            Product pC = new ProductC("product c", "info b", 500, 0);
            MachineProducts.AddProduct(pC, 30);

        }
    }
}
