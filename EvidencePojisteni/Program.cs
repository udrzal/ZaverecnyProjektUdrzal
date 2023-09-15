namespace EvidencePojisteni
{
     // *** Jan Udržal - Evidence pojištění, projekt ke zkoušce ***  \\
    internal class Program
    {
        static void Main(string[] args)
        {
            Dialog dialog = new Dialog();
            int volba = 0;
            List<Pojisteny> SeznamPojistenych = new List<Pojisteny>();
            //SeznamPojistenych = Test.Predvypln(); // Předvyplní seznam pojištěných - slouží pro testovací účely

            while (volba != 4) 
            {
                dialog.VypisNabidku();
                if (int.TryParse(Console.ReadLine(), out volba))
                {
                    switch (volba)
                    {
                        case 1:
                            SeznamPojistenych.Add(dialog.VytvorPojisteneho());
                            break;
                        case 2:
                            dialog.VytvorHlavickuTabulky();
                            foreach (Pojisteny p in SeznamPojistenych)
                                dialog.VypisPolozku(p);
                            break; 
                        case 3:
                            string zadaneJmeno = (dialog.ZadejVyhledavani(0)).ToLower();
                            string zadanePrijmeni = (dialog.ZadejVyhledavani(1)).ToLower();
                            dialog.VytvorHlavickuTabulky();
                            foreach (Pojisteny p in SeznamPojistenych)
                            {
                                string jmeno = p.Jmeno.ToLower();
                                string prijmeni = p.Prijmeni.ToLower();
                                if ((jmeno == zadaneJmeno) && (prijmeni == zadanePrijmeni))
                                    dialog.VypisPolozku(p);
                            }
                            break;
                    }
                }
                dialog.VypisZpravu(volba);
            }
        }
    }
}