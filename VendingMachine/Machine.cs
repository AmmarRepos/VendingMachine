using VendingMachine;
namespace VendingMachine
{
    public class Machine : IVending
    {
        public string Name = "a standard machine";
        public Products products = new Products();
        public Cash cash = new Cash();
        public Machine()
        {
            Console.WriteLine($"this is {this.Name}");
            Console.WriteLine("0: Start Machine\n1: empty machine\n9: Shutdown Machine (i.e Program)");
        }
        public void ShowMenu()
        {
            Console.WriteLine("\nPlease enter your choice.");
            Console.WriteLine("S: Show avaialbe product\nI: Insert Money\nA: Purchase A\nB: Purchase B\nC: Purchase C \nE: End Transaction");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.I:
                    Console.Write("\nPlease Insert Money:");
                    int money = int.Parse(Console.ReadLine()!);
                    IVending.InsertMoney(cash, money);
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    StartMachine();
                    break;
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    EmptyMachine();
                    break;
                case ConsoleKey.A:
                    IVending.Purchase(products, cash, products.productsList[0]);
                    break;
                case ConsoleKey.B:
                    IVending.Purchase(products, cash, products.productsList[1]);
                    break;
                case ConsoleKey.C:
                    IVending.Purchase(products, cash, products.productsList[2]);
                    break;
                case ConsoleKey.S:
                    IVending.ShowAll(products);
                    break;
                case ConsoleKey.E:
                    IVending.EndTransction(cash);
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.WriteLine("\nSHUTTING DOWN ... Good bye");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            ShowMenu();
        }
        public void EmptyMachine()
        {
            cash.clientBalance = 0;
            cash.machineBalance = 0;
            products.productsList.Clear();

        }

        public void StartMachine()
        {
            cash.clientBalance = 0;
            cash.machineBalance = 0;
            Product pA = new ProductA("product a", "info a", 10, 0);
            products.AddProduct(pA, 10);
            Product pB = new ProductB("product b", "info b", 100, 0);
            products.AddProduct(pB, 20);
            Product pC = new ProductC("product c", "info b", 500, 0);
            products.AddProduct(pC, 30);
            Product pAa = new ProductA("product aa", "info aa", 11, 0);
            products.AddProduct(pA, 10);
            Product pBb = new ProductB("product bb", "info bb", 550, 0);
            products.AddProduct(pB, 20);
            Product pCc = new ProductC("product cc", "info cc", 700, 0);
            products.AddProduct(pC, 30);
        }
    }
}