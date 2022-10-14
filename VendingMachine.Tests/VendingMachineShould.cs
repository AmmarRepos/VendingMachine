using System.Transactions;

namespace VendingMachine.Tests
{
    public class VendingMachineShould
    {

        [Fact]
        public void IVendingPurchaseQuantity()
        {
            Machine sut = new();
            sut.EmptyMachine();
            sut.StartMachine();
            IVending.InsertMoney(sut.cash, 10);
            IVending.Purchase(sut.products, sut.cash, sut.products.productsList[0]);
            Assert.Equal(9, sut.products.productsList[0].quantity);
        }
        [Fact]
        public void EmptyMachineTest()
        {
            Machine sut = new();
            sut.StartMachine();
            sut.EmptyMachine();
            Assert.Equal(0, sut.products.productsList.Count!);
        }

        [Fact]
        public void IVendingPurchaseMachineBalance()
        {
            Machine sut = new();
            sut.EmptyMachine();
            sut.StartMachine();
            IVending.InsertMoney(sut.cash, 10);
            IVending.Purchase(sut.products, sut.cash, sut.products.productsList[0]);
            Assert.Equal(10, sut.cash.machineBalance);
        }

        [Fact]
        public void IVendingInsertRightMoeny()
        {
            Machine sut = new();
            sut.EmptyMachine();
            sut.StartMachine();
            IVending.InsertMoney(sut.cash,100);
            Assert.Equal(100, sut.cash.clientBalance);
        }

        [Fact]
        public void IVendingInsertWrongMoeny()
        {
            Machine sut = new();
            sut.EmptyMachine();
            sut.StartMachine();
            IVending.InsertMoney(sut.cash, 150);
            Assert.Equal(0, sut.cash.clientBalance);
        }
    }
}