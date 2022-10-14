using System.Transactions;

namespace VendingMachine.Tests
{
    public class VendingMachineShould
    {
        Machine machine = new();

        [Fact]
        public void IVendingPurchaseQuantity()
        {
            machine.EmptyMachine();
            machine.StartMachine();
            IVending.InsertMoney(machine.cash, 10);
            IVending.Purchase(machine.products, machine.cash, machine.products.productsList[0]);
            Assert.Equal(9, machine.products.productsList[0].quantity);
        }
        [Fact]
        public void EmptyMachineTest()
        {
            machine.StartMachine();
            machine.EmptyMachine();
            Assert.Equal(0, machine.products.productsList.Count!);
        }

        [Fact]
        public void IVendingPurchaseMachineBalance()
        {
            machine.EmptyMachine();
            machine.StartMachine();
            IVending.InsertMoney(machine.cash, 10);
            IVending.Purchase(machine.products, machine.cash, machine.products.productsList[0]);
            Assert.Equal(10, machine.cash.machineBalance);
        }

        [Fact]
        public void IVendingInsertRightMoeny()
        {
            machine.EmptyMachine();
            machine.StartMachine();
            IVending.InsertMoney(machine.cash,100);
            Assert.Equal(100, machine.cash.clientBalance);
        }

        [Fact]
        public void IVendingInsertWrongMoeny()
        {
            machine.EmptyMachine();
            machine.StartMachine();
            IVending.InsertMoney(machine.cash, 150);
            Assert.Equal(0, machine.cash.clientBalance);
        }
    }
}