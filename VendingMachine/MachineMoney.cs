
namespace VendingMachine
{
    public class MachineMoney
    {
        public static int machineBalance = 0;
        public static int clientBalance = 0;
        public static readonly int[] denominations = new int[7] { 1, 5, 10, 20, 100, 500, 1000 };
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
        public static void DecreaseCash(int amount)
        {
            clientBalance -= amount;
        }
        public static void ReturnCash(int amount)
        {
            Console.Write("Here is the rest of your money:");
            Array.Sort(denominations);
            foreach (int demonation in denominations)
            {
                while(amount > demonation)
                {
                    Console.Write($"{demonation} , ");
                    amount -= demonation;
                    machineBalance -= demonation;
                    clientBalance -= demonation;
                }
            }
        }
    }
}