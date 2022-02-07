﻿using Banking;
using System;

namespace BankingProject {
    class Program {
        static void Main(string[] args) {

            Account acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Debug();
            //acct1.Withdraw(600);
            //acct1.Debug();


            Account acct2 = new Account();
            acct2.Description = "my 2nd account";
            acct2.Deposit(1000);
            acct2.Withdraw(350);
            acct2.Debug();

            acct2.Transfer(100, acct1);
            acct1.Debug();
            acct2.Debug();
        }
    }
}
