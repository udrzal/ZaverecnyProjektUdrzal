using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída sloužící pro výpis dat do konzole
    /// </summary>
    internal class Dialog
    {
        /// <summary>
        /// Vypíše očíslované menu pro výběr akce
        /// </summary>
        public void VypisNabidku() 
        {
            Console.Clear();
            Console.WriteLine(@"
  --------------------------------
  Evidence pojištěných
  --------------------------------

  Vyberte si akci:
  1 - Přidat nového pojištěného
  2 - Vypsat všechny pojištěné
  3 - Vyhledat pojištěného
  4 - Konec");
        }

        /// <summary>
        /// Vypíše pokyny k zadání údajů pro vytvoření pojištěné osoby
        /// </summary>
        public Pojisteny VytvorPojisteneho()
        {
            Console.WriteLine();
            Console.WriteLine(" Zadejte křestní jméno pojištěného:");
            string jmeno = Console.ReadLine().Trim();
            Console.WriteLine(" Zadejte příjmení:");
            string prijmeni = Console.ReadLine().Trim();
            int vek;
            Console.WriteLine(" Zadejte věk:");
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zadejte věk (číselnou hodnotu bez mezer):");
                Console.ResetColor();
            }
            Console.WriteLine(" Zadejte telefon:");
            string telefon = Console.ReadLine().Trim();
            Pojisteny pojisteny = new Pojisteny(jmeno, prijmeni, vek, telefon);
            return pojisteny;
        }

        /// <summary>
        /// Vypíše pokyny k zadání jména a příjmení podle parametru j
        /// </summary>
        /// <param name="j"></param>
        /// <returns>Jméno nebo příjmení podle parametru j</returns>
        public string ZadejVyhledavani(int j)
        {
            if (j == 0)
            {
                Console.WriteLine();
                Console.WriteLine(" Zadejte křestní jméno pojištěného:");
                return Console.ReadLine().Trim();
            }
            Console.WriteLine(" Zadejte příjmení:");
            return Console.ReadLine().Trim();
        }

        /// <summary>
        /// Vypíše potvrzení provedení a pokyn k pokračování
        /// </summary>
        /// <param name="volba"></param>
        public void VypisZpravu(int volba)
        {
            Console.WriteLine();
            switch (volba)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Data byla uložena. ");
                    Console.ResetColor();
                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    break;
                case 2:
                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    break;
                case 3:
                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(" Na shledanou...");
                    Thread.Sleep(700);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Neplatná volba, opakujte výběr akce. ");
                    Console.ResetColor();
                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    break;
            }
            if (volba != 4)
                Console.ReadKey();
        }

        /// <summary>
        /// Vypíše hlavičku tabulky pro označení významu jednotlivých sloupců
        /// </summary>
        public void VytvorHlavickuTabulky()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Jméno", "Příjmení", "Věk", "Telefon");
            Console.ResetColor();
        }

        /// <summary>
        /// Vypíše danou položku
        /// </summary>
        /// <param name="p">Předává uživatele k vypsání</param>
        public void VypisPolozku(Pojisteny p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(p);
            Console.ResetColor();
        }
    }
}
