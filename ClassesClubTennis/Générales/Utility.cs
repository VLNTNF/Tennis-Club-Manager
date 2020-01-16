using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesClubTennis
{
    public class Utility
    {
        public static string SaisieEntree(string entree)
        {
            string res;
            do
            {
                Console.Write(entree);
                res = Console.ReadLine();
            } while ((res == "") || (res == " "));
            return res;
        }

        public static DateTime SaisieDate(string entree)
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

        public static int SaisiePositive(string entree)
        {
            bool test = true;
            int x = -1;
            do
            {
                try
                {
                    x = Convert.ToInt32(SaisieEntree(entree));
                }
                catch (FormatException)
                {
                    test = false;
                }
                if (x < 0)
                {
                    test = false;
                }
                else
                {
                    test = true;
                }
            } while (test == false);
            return x;
        }
    }
}
