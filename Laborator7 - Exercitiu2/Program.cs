using System;

namespace Laborator7___Exercitiu2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 7 - Exercitiu 2 - Conturi Bancare

            //Scrieti un program care va modela conturile bancare. Un cont bancar poate fi de  economii sau cont curent. 

            //In ambele conturi vom putea depune bani.
            //- La depunerea banilor soldul curent va crește cu valoarea depusa

            //Din ambele contrui vom putea extrage bani.
            // - În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afișat un mesaj corespunzator, iar suma extrasă va fi 0.

            //Contul de economii va oferi posibilitatea recalculării soldului astfel încât noului sold îi va fi adaugată dobânda corespunzatoare, valoarea dobânzii fiind
            // specificată la fiecare recalculare.

            // Creeați clasele, adăugați câteva instanțe in Main, testați și rulați programul

            ContBancar saving = new Economii();
            ContBancar chequing = new Curent();
            ContBancar savingsinterest = new Economii();

            Console.WriteLine("CONTUL ECONOMII+DOBANDA");
            savingsinterest.Dobanda(100);
            savingsinterest.Dobanda(150);
            Console.WriteLine($"Soldul Contului de Economii Este: {savingsinterest.BalanceInterest}");


            Console.WriteLine("CONT CURENT\n");
            chequing.Depozitare(110);
            chequing.Retragere(150);
            Console.WriteLine($"Soldul Contului Curent Este: {chequing.Balance}\n");

            Console.WriteLine("CONTUL ECONOMII\n");
            saving.Depozitare(100);
            saving.Depozitare(500);
            saving.Depozitare(2000);
            saving.Retragere(120);
            saving.Retragere(1700);
            Console.WriteLine($"Soldul Contului de Economii Este: {saving.Balance}");
        }
    }
}
