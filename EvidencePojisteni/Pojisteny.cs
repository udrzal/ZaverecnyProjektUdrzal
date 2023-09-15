using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentuje pojištěnou osobu
    /// </summary>
    internal class Pojisteny
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string Telefon { get; private set; }

        /// <summary>
        /// Vytvoří pojištěnou osobu
        /// </summary>
        /// <param name="jmeno">Jméno pojištěné osoby</param>
        /// <param name="prijmeni">Příjmení pojištěné osoby</param>
        /// <param name="vek">Věk pojištěné osoby</param>
        /// <param name="telefon">Kontaktní telefon na pojištěnou osobu</param>
        public Pojisteny(string jmeno, string prijmeni, int vek, string telefon) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        /// <summary>
        /// Vypíše jméno, příjmení, věk a telefon dané osoby
        /// </summary>
        /// <returns>Vrací řetězec s příslušnými údaji pojištěné osoby</returns>
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", Jmeno, Prijmeni, Vek, Telefon); // zarovnání v reálu neodpovídá zadaným hodnotám -> KONZULTACE
        }
    }
}
