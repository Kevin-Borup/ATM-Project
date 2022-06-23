using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM_TDD
{
    public class Bank
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private int bankId;

        public int BankId
        {
            get { return bankId; }
            private set { bankId = value; }
        }



        private List<Account> accounts;

        public bool IsAccountHere(int accountNr)
        {
            foreach (Account account in accounts)
            {
                if (account.AccountNr == accountNr)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateCard()
        {
            return false;
        }

        public void Withdraw()
        {

        }

        public void Deposit()
        {

        }

        public int CreateAccount(string name)
        {
            Random random = new Random();
            int accountNrLength = 10;

            string accountNr = string.Empty;

            for (int i = 0; i < accountNrLength; i++)
                accountNr = String.Concat(accountNr, random.Next(10).ToString());

            int accountNrInt = Convert.ToInt32(accountNr);
            accounts.Add(new Account(accountNrInt, name));

            return accountNrInt;
        }

        public Card AddCardToAccount(int accountNr, out int pin)
        {
            string cardNum = BankId.ToString();
            string cardName = string.Empty;
            DateOnly cardExp = DateOnly.FromDateTime(DateTime.Now).AddYears(3);
            int cardCVC;
            int registrationNr = BankId;

            Random random = new Random();
            int cardNumLength = 16;
            int cardCVCLength = 3;

            for (int i = 0; i < cardNumLength; i++)
                cardNum = String.Concat(cardNum, random.Next(10).ToString());

            string cardCVCString = string.Empty;

            for (int i = 0; i < cardCVCLength; i++)
                cardCVCString = String.Concat(cardCVCString, random.Next(10).ToString());

            cardCVC = Convert.ToInt32(cardCVCString);

            foreach (Account account in accounts)
            {
                if (account.AccountNr == accountNr)
                {
                    cardName = account.OwnerName;

                    Card newCard = new Card(cardNum, cardName, cardExp, cardCVC, registrationNr, accountNr);

                    pin = account.AddCard(newCard);

                    return newCard;
                }
            }

            throw new Exception("No Such Account");
        }

        public Bank(string name, int id)
        {
            Name = name;
            BankId = id;
            accounts = new List<Account>();
        }
    }
}
