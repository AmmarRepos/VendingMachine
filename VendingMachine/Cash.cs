
namespace VendingMachine
{
    public class Cash
    {
        public int machineBalance;
        public int clientBalance;
        public static readonly int[] denominations = new int[7] {1000, 500, 100, 20, 10, 5, 1};
        public static bool ValidateInput(int input)
        {
            return Array.Exists(denominations, element => element == input);
        }
        public static void SpiteInput()
        {
            Console.WriteLine("\nThis money do not work here");
        }
        public void IncreaseCash(int amount)
        {
            machineBalance += amount;
            clientBalance += amount;
            ShowBalances();
        }
        public void DecreaseClientBalance(int amount)
        {
            clientBalance -= amount;
            ShowBalances();
        }
        public void ShowBalances()
        {
            Console.WriteLine($"\nClient:{clientBalance}, Machine:{machineBalance}");
        }
        public void ReturnCash()
        {
            Console.WriteLine("\nHere is the rest of your money:");
            foreach (int demonation in denominations)
            {
                while(clientBalance >= demonation)
                {
                    Console.WriteLine($"{demonation}");
                    machineBalance -= demonation;
                    clientBalance -= demonation;
                }
            }
        }
    }
}