using Xunit;
using ConsoleApp_ATM_TDD;

namespace TestProject_ATM
{
    public class ATMTests
    {
        [Fact]
        public void InsertCard_GetBankOfCard()
        {
            Bank bank = new Bank("Sydbank", 5170);
            int accountNr = bank.CreateAccount("Kevin");
            Card createdCard = bank.AddCardToAccount(accountNr, out int pin);

            ATM atm = new ATM();
            atm.AddBank(bank);

            string bankName = atm.InsertCard(createdCard);

            Assert.Equal("Sydbank", bankName);
        }
    }

    //    [Fact]
    //    public void WritePin_ValidateCardPin()
    //    {
    //        Bank bank = new Bank("Sydbank", 5170);
    //        int accountNr = bank.CreateAccount("Kevin");
    //        Card createdCard = bank.AddCardToAccount(accountNr, out int pin);

    //        ATM atm = new ATM();
    //        atm.AddBank(bank);

    //        atm.InsertCard(createdCard);
    //        bool success = atm.WritePin(pin);

    //        Bank bank = new Bank();
    //        Card card = new Card();
    //        ATM atm = new ATM();

    //        string bank = atm.WritePin(card);

    //        Assert.Equal("Sydbank", bank);
    //    }

    //    [Theory]
    //    [InlineData(1324)]
    //    public void WritePin_ValidateCardPin(int pin)
    //    {
    //        Bank bank = new Bank("Sydbank", 5170);
    //        int accountNr = bank.CreateAccount("Kevin");
    //        Card createdCard = bank.AddCardToAccount(accountNr, out int actualPin);

    //        ATM atm = new ATM();
    //        atm.AddBank(bank);

    //        atm.InsertCard(createdCard);
    //        bool succes = atm.WritePin(pin);

    //        Bank bank = new Bank();
    //        Card card = new Card();
    //        ATM atm = new ATM();

    //        string bank = atm.WritePin(card);

    //        Assert.Equal("Sydbank", bank);
    //    }
    //}

    //public class BankTests
    //{
    //    [Fact]
    //    public void ValidateCard_CheckIfCardIsValid()
    //    {
    //        Card card = new Card();
    //        Bank bank = new Bank();

    //        bool succesful = bank.ValidateCard(card);

    //        Assert.True(succesful);
    //    }
    //}

    //public class AccountTests
    //{
    //    [Theory]
    //    [InlineData(20000)]
    //    public void Balance_WithdrawFromAccount(decimal amount)
    //    {
    //        Bank bank = new Bank();
    //        Account account = new Account();

    //        bool succesful = account.BalanceWithdraw(amount);

    //        Assert.True(succesful);
    //    }                             
    //}
}