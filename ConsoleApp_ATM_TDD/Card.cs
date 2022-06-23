using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ATM_TDD
{
    public class Card
    {
        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            private set { cardNumber = value; }
        }

        private string cardName;

        public string CardName
        {
            get { return cardName; }
            private set { cardName = value; }
        }

        private DateOnly cardExp;

        public DateOnly CardExp
        {
            get { return cardExp; }
            private set { cardExp = value; }
        }

        private int cardCVC;

        public int CardCVC
        {
            get { return cardCVC; }
            private set { cardCVC = value; }
        }

        private int registrationNr;

        public int RegistrationNr
        {
            get { return registrationNr; }
            private set { registrationNr = value; }
        }

        private int accountNr;

        public int AccountNr
        {
            get { return accountNr; }
            private set { accountNr = value; }
        }

        public Card(string cardNumber, string cardName, DateOnly cardExp, int cardCVC, int registrationNr, int accountNr)
        {
            CardNumber = cardNumber;
            CardName = cardName;
            CardExp = cardExp;
            CardCVC = cardCVC;
            RegistrationNr = registrationNr;
            AccountNr = accountNr;
        }


    }
}
