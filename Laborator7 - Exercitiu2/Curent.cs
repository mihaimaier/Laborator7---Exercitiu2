using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7___Exercitiu2
{
    class Curent : ContBancar
    {
		private decimal _balance;
		private decimal _balanceinterest = 0;

		public void Depozitare(decimal amount)
		{
			Console.WriteLine($"Soldul Este: {_balance += amount}.");
		}

		public void Retragere(decimal amount)
		{
			if(_balance < amount)
            {
				Console.WriteLine("Soldul Extras Este: {0}. !!!Fonduri Insuficiente!!!", amount);
				amount = 0;
			}
            else
            {
				Console.WriteLine($"Soldule Este: {_balance -= amount}.");
			}
		}

        public decimal Balance { get { return _balance; } }

		public decimal BalanceInterest { get { return _balanceinterest; } }
	}
}
