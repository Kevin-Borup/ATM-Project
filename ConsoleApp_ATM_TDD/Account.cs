using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM_TDD
{
    public class Account
    {
        private List<Cards> cards;
        private decimal balance;
        private int accountNr;

        private string ownerName;

        public string OwnerName
        {
            get { return ownerName; }
            private set { ownerName = value; }
        }


        public int AccountNr
        {
            get { return accountNr; }
            private set { accountNr = value; }
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public int AddCard(Card card)
        {
            var random = new Random();
            int pinCodeLength = 4;
            string pinCode = string.Empty;

            for (int i = 0; i < pinCodeLength; i++)
                pinCode = String.Concat(pinCode, random.Next(10).ToString());

            int pinCodeInt = Convert.ToInt32(pinCode);
            cards.Add(new Cards(card, pinCodeInt));
            return pinCodeInt;
        }

        public bool ConfirmPin(Card recievedCard, int pinCode)
        {
            foreach (Cards card in cards)
            {
                if (card.Card == recievedCard)
                {
                    if (card.PinCode == pinCode)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public Account(int accountNr, string ownerName)
        {
            cards = new List<Cards>();

            AccountNr = accountNr;
            OwnerName = ownerName;

            balance = 0;
        }

        private struct Cards
        {
            public Cards(Card card, int pinCode)
            {
                Card = card;
                PinCode = pinCode;
            }

            public Card Card { get; }
            public int PinCode { get; }
        }
    }
}
