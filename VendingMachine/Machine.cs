using VendingMachine;
namespace VendingMachine
{
    internal class Machine : IVending
    {
        public string Name = "a standard machine";
        public Machine()
        {
            Console.WriteLine($"this is {this.Name}");
            Products products = new Products();
            Cash cash = new Cash();
            IVending.StartMachine(products, cash);
            IVending.ShowMenu(products, cash);
        }
    }
}