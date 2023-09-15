using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída sloužící k předvyplnění seznamu pro testovací účely
    /// </summary>
    internal class Test
    {
        /// <summary>
        /// Vytvoří několik pojištěných z přednastavených hodnot a uloží je do seznamu
        /// </summary>
        /// <returns>Vrací seznam pojištěných</returns>
        public static List<Pojisteny> Predvypln()
        {
            List<Pojisteny> SeznamPredvyplneny = new List<Pojisteny>();
            Pojisteny adam = new Pojisteny("Adam", "Andrejs", 35, "606002126");
            SeznamPredvyplneny.Add(adam);
            Pojisteny bohumil = new Pojisteny("Bohumil", "Barták", 42, "777255321");
            SeznamPredvyplneny.Add(bohumil);
            Pojisteny cyril = new Pojisteny("Cyril", "Cerha", 85, "602088518");
            SeznamPredvyplneny.Add(cyril);
            Pojisteny daniel = new Pojisteny("Daniel", "Dudek", 21, "775299010");
            SeznamPredvyplneny.Add(daniel);
            Pojisteny emil = new Pojisteny("Emil", "Ehrenberger", 48, "606788660");
            SeznamPredvyplneny.Add(emil);
            Pojisteny filipSt = new Pojisteny("Filip", "Fiala", 53, "605204725");
            SeznamPredvyplneny.Add(filipSt);
            Pojisteny filipMl = new Pojisteny("Filip", "Fiala", 26, "776218262");
            SeznamPredvyplneny.Add(filipMl);
            return SeznamPredvyplneny;
        }
    }
}
