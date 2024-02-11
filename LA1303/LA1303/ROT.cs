using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA1303
{
    public class ROT
    {

        public void Rot()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Möchten Sie Verschlüsseln[V] / Entschlüsseln [E] ?");
            string voe = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihre Botschaft ein:");
            string btschft = Console.ReadLine();

            string ausgabe;

            if(voe == "V")
            {
                ausgabe = Verschluesseln(btschft);
                Console.WriteLine("Ihre verschlüsselte Botschaft: " +ausgabe);
            }
            else if (voe == "E")
            {
                ausgabe = Entschluesseln(btschft);
                Console.WriteLine("Ihre entschlüsselte Botschaft: " +ausgabe);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
            static string Verschluesseln(string btschft)
            {
                char[] bstbn = btschft.ToCharArray();
                for(int i= 0; i < bstbn.Length; i++)
                {
                    if (char.IsLetter(bstbn[i]))
                    {
                        char bstbn1 = char.IsUpper(bstbn[i])? 'A':'a';
                        bstbn[i] = (char)(((bstbn[i] - bstbn1 + 13) % 26) + bstbn1);
                    }
                }
                return new string(bstbn);
            }
            static string Entschluesseln(string btschft)
            {
                return Verschluesseln(btschft);
            }
        }
    }
}
