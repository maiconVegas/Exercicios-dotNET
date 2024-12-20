﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.interest_is_interesting
{
    internal static class SavingsAccount
    {
        public static float InterestRate(decimal balance) =>
            balance < 0 ? 3.213f :
            balance < 1000 ? 0.5f :
            balance < 5000 ? 1.621f : 2.475f;

        public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

        public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 0;
            while (targetBalance > balance)
            {
                balance = AnnualBalanceUpdate(balance);
                //targetBalance -= Math.Round(Interest(balance), 2);
                years++;
            }
            return years;
        }
    }
}
