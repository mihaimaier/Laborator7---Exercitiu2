using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7___Exercitiu2
{
    class Economii : ContBancar
    {
		private decimal _balance;
		private decimal _interestbalance;
		public void Depozitare(decimal amount)
		{
				Console.WriteLine($"Soldul Este: {_balance += amount}.");
		}

		public void Dobanda(decimal amount)
        {
			decimal rate;
			Console.Write("Introduceti o dobanda:");
			rate = Convert.ToDecimal(Console.ReadLine());
			decimal rateFinal = (rate/100);
			_interestbalance = amount * rateFinal;
        }

		public void Retragere(decimal amount)
		{
			if (_balance < amount)
			{
				Console.WriteLine("Soldul Extras Este: {0}. !!!Fonduri Insuficiente!!!", amount);
				amount = 0;
			}
			else
			{
				Console.WriteLine($"Soldul Este: {_balance -= amount}.");
			}
		}

        public decimal Balance { get { return _balance; } }

		public decimal BalanceInterest { get { return _interestbalance; } }
	}
}
