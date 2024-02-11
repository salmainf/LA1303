using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA1303
{
    public class Sub
    {
        public void Subs()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Möchten Sie Verschlüsseln[V] / Entschlüsseln [E] ?");
            string voe = Console.ReadLine();

            Console.WriteLine("Geben Sie einen Schlüssel ein (Alphabet in beliebiger Reihenfolge):");
            string schlssl = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihre Botschaft ein:");
            string btschft = Console.ReadLine().ToLower();

            string ausgabeVB = "";
            string ausgabeEB = "";

            if (voe == "V")
            {
                ausgabeVB = Verschluesseln(btschft, schlssl);
                Console.WriteLine("Ihre verschlüsselte Botschaft: " + ausgabeVB);





            }
            else if (voe == "E")
            {

                ausgabeEB = Entschluesseln(btschft, schlssl);
                Console.WriteLine("Ihre entschlüsselte Botschaft: " + ausgabeEB);
            }else if (voe == "")
            {

                Console.WriteLine("Ungültige Eingabe! Geben Sie Ihre Wahl richtig an:");
            }


            static string Verschluesseln(string btschft, string schlssl)
            {


                string alphbt = "abcdefghijklmnopqrstuvwxyz";
                string ausgabeVB = "";

                foreach(char bstb in btschft)
                {
                    if (char.IsLetter(bstb))
                    {
                        int index=alphbt.IndexOf(bstb);
                        ausgabeVB += schlssl[index];
                    }
                    else
                    {
                        ausgabeVB += bstb;

                    }
                }
                return ausgabeVB;

            }

            static string Entschluesseln (string btschft, string schlssl)
            {
                string alphbt = "abcdefghijklmnopqrstuvwxyz";
                string ausgabeEB = "";

                foreach(char bstb in btschft)
                {
                    if (char.IsLetter(bstb))
                    { 
                        int index=schlssl.IndexOf(bstb);
                        ausgabeEB += alphbt[index];
                    }
                    else
                    {
                        ausgabeEB+=bstb;
                    }
                }
                return ausgabeEB;
            }
        }
    }
}
