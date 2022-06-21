using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7___Exercitiu2
{
    interface ContBancar
    {
        decimal Balance { get; }

        decimal BalanceInterest { get; }

        void Depozitare(decimal amount);
        void Retragere(decimal amount);
        void Dobanda(decimal amount);
    }
}
