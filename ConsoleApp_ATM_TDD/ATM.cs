using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM_TDD
{
    public class ATM
    {
        private List<Bank> banks;
        private Card? insertedCard;

        public string InsertCard(Card card)
        {
            insertedCard = card;

            foreach (Bank bank in banks)
            {
                if (bank.IsAccountHere(card.AccountNr))
                {
                    return bank.Name;
                }
            }

            return string.Empty;
        }

        public bool WritePin(int pin)
        {
            if (insertedCard != null)
            {

            }

            return true;
        }

        public void ContactBank()
        {
            if (insertedCard != null)
            {

            }
        }

        public void Deposit()
        {
            if (insertedCard != null)
            {

            }
        }

        public void Withdraw()
        {
            if (insertedCard != null)
            {

            }
        }

        public void RemoveCard()
        {
            insertedCard = null;
        }

        public void AddBank(Bank bank)
        {
            banks.Add(bank);
        }

        public ATM()
        {
            banks = new List<Bank>();
        }
    }
}
