using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis
{
    public class Utility
    {
        public string SaisieEntree(string entree)
        {
            string res;
            do
            {
                Console.Write(entree);
                res = Console.ReadLine();
            } while ((res == "") || (res == " "));
            return res;
        }

        public DateTime SaisieDate(string entree)
        {
            DateTime res;
            string saisie;
            bool test;
            do
            {
                Console.Write(entree);
                saisie = Console.ReadLine();
                test = DateTime.TryParse(saisie, out res);
            } while (test == false);
            return res;
        }
    }
}
