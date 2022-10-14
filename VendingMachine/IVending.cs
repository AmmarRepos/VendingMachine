using VendingMachine;
namespace VendingMachine
{

    public interface IVending
    {

        public static void ShowMenu(Products machineProducts, Cash machineCash)
        {
            Console.WriteLine("\nPlease enter your choice.");
            Console.WriteLine("S: Show avaialbe product\nI: Insert Money\nE: End Transaction");
            Console.WriteLine("A: Purchase A\nB: Purchase B\nC: Purchase C");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.I:
                    InsertMoney(machineCash);                    
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    StartMachine(machineProducts, machineCash);
                    break;
                case ConsoleKey.A:
                    Purchase(machineProducts, machineCash, machineProducts.products[0]);
                    break;
                case ConsoleKey.B:
                    Purchase(machineProducts, machineCash, machineProducts.products[1]);
                    break;
                case ConsoleKey.C:
                    Purchase(machineProducts, machineCash, machineProducts.products[2]);
                    break;
                case ConsoleKey.S:
                    ShowAll(machineProducts);
                    break;
                case ConsoleKey.E:
                    EndTransction(machineCash);
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.WriteLine("\nSHUTTING DOWN ... Good bye");
                    break;
                default:
                    break;
            }
            ShowMenu(machineProducts, machineCash);
        }
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
            foreach (Product product in machineProducts.products)
            {
                Console.WriteLine($"{product.name}, {product.price}, {product.quantity}");
            }
        }
        public static void InsertMoney(Cash machineCash)
        {
            Console.Write("\nPlease Insert Money:");
            int money = int.Parse(Console.ReadLine()!);
            if (Cash.ValidateInput(money))
            { 
                machineCash.IncreaseCash(money);
            }
            else
                Cash.SpiteInput();
        }     
        public static void EndTransction(Cash machineCash)
        {
            machineCash.ReturnCash();
            Console.WriteLine("WELCOME");
        }
        public static void StartMachine(Products machineProducts, Cash machineCash)
        {
            machineCash.clientBalance = 0;
            machineCash.machineBalance = 0;
            Product pA = new ProductA("product a", "info a", 10, 0);
            machineProducts.AddProduct(pA, 10);
            Product pB = new ProductB("product b", "info b", 100, 0);
            machineProducts.AddProduct(pB, 20);
            Product pC = new ProductC("product c", "info b", 500, 0);
            machineProducts.AddProduct(pC, 30);

        }
    }
}
