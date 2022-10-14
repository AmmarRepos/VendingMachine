using VendingMachine;

namespace VendingMachine
{
    static class Program
    {
        public static void Main()
        {
            Machine machine = new ();
            machine.StartMachine();
            machine.ShowMenu();
        }
    }
}
