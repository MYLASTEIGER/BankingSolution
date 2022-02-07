using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    public class Account {
        //static properties
        private static int NextAccountNumber { get; set; } = 1;
        //INSTANCE Properties
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public string Description { get; set; }
        //Methods
        public bool Deposit(Decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive."); 
            }
            Balance = Balance + Amount;
            return true;
        }
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            if(Amount > Balance) {
                throw new Exception("Insufficient Funds");
            }
            Balance = Balance - Amount;
            return true;
        }
        public bool Transfer(decimal Amount, Account ToAccount) {
            try { 
                Withdraw(Amount);
            }catch (Exception) {
                throw new Exception("Withdraw Failed in Transfer");
            }
            ToAccount.Deposit(Amount);
            return true;

        }
        public void Debug() {
            Console.WriteLine($"{AccountNumber}|{Description}|{Balance:c}");
        }
            //Constructors
            public Account() {//default contructor
            AccountNumber = NextAccountNumber;
            NextAccountNumber++;
            Description = "New Account";
            Balance = 0;

            }

        }


    }

