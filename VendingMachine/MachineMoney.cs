
namespace VendingMachine
{
    public class MachineMoney
    {
        public static int machineBalance;
        public static int clientBalance;
        public static readonly int[] denominations = new int[7] {1000, 500, 100, 20, 10, 5, 1};
        private static bool ValidateInput(int input)
        {
            return Array.Exists(denominations, element => element == input);
        }
        void SpiteInput()
        {
            Console.WriteLine("This money do not work here");
        }
        public static void IncreaseCash(int amount)
        {
            if (ValidateInput(amount))
                machineBalance += amount;
                clientBalance += amount;
        }
        public static void DecreaseClientBalance(int amount)
        {
            clientBalance -= amount;
            Console.WriteLine($"{clientBalance}, {machineBalance}");
        }
        public static void ReturnCash(int amount)
        {
            Console.WriteLine("Here is the rest of your money:");
            foreach (int demonation in denominations)
            {
                while(amount >= demonation)
                {
                    Console.WriteLine($"{demonation}");
                    amount -= demonation;
                    machineBalance -= demonation;
                    clientBalance -= demonation;
                }
            }
        }
    }
}