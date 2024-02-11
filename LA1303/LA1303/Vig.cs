namespace LA1303
{
    public class Vig
    {
        public void Vign()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Möchten Sie Verschlüsseln[V] / Entschlüsseln [E] ?");
            string voe = Console.ReadLine();

            if (voe == "V")
            {
                Console.WriteLine("Geben Sie einen Schlüssel ein:");
                string schlssl = Console.ReadLine();

                Console.WriteLine("Geben Sie Ihre Botschaft ein:");
                string btschft = Console.ReadLine();

                string schlsslVerschieben = SchlsslVerschieben(schlssl, btschft);
                string ausgabe = Verschluesseln(btschft, schlsslVerschieben);
                Console.WriteLine(ausgabe);
            }
            else if (voe == "E")
            {

                Console.WriteLine("Geben Sie einen Schlüssel ein:");
                string schlssl2 = Console.ReadLine();

                Console.WriteLine("Geben Sie Ihre Botschaft ein");
                string btschft2 = Console.ReadLine();



                string schlsslVerschieben2 = SchlsslVerschieben2(schlssl2, btschft2);
                string ausgabe2 = Entschluesseln(btschft2, schlsslVerschieben2);
                Console.WriteLine(ausgabe2);


            }

            static string SchlsslVerschieben(string schlssl, string btschft)
            {
                if (schlssl.Length == btschft.Length)
                {
                    return schlssl;
                }
                else if (schlssl.Length > btschft.Length)
                {
                    int zeichenLenght = btschft.Length;

                    return schlssl.Substring(0, zeichenLenght);
                }
                else
                {
                    string wiederholterSchluessel = "";

                    for (int i = 0; i < btschft.Length; i++)
                    {
                        wiederholterSchluessel = wiederholterSchluessel + schlssl[i % schlssl.Length];
                    }
                    return wiederholterSchluessel;
                }


            }
            static string SchlsslVerschieben2(string schlssl2, string btschft2)
            {
                if (schlssl2.Length == btschft2.Length)
                {
                    return schlssl2;
                }
                else if (schlssl2.Length > btschft2.Length)
                {
                    int btschft2Lenght = schlssl2.Length;
                    return schlssl2.Substring(0, btschft2Lenght);
                }
                else
                {
                    string wiederholterSchluessel = "";

                    for (int i = 0; i < btschft2.Length; i++)
                    {
                        wiederholterSchluessel = wiederholterSchluessel + schlssl2[i % schlssl2.Length];
                    }
                    return wiederholterSchluessel;
                }

            }



            static char BtschftVerschluesseln(char zeichen, int schluessel)
            {
                string buchstaben = "abcdefghijklmnopqrstuvwxyz";
                if (!buchstaben.Contains(zeichen))
                {
                    return zeichen;
                }
                int position = buchstaben.IndexOf(zeichen);

                int verschluesselt = (position + schluessel) % 26;
                return buchstaben[verschluesselt];

            }
            static char BtschftEntschluesseln(char zeichen, int schluessel)
            {
                string buchstaben = "abcdefghijklmnopqrstuvwxyz";
                if (!buchstaben.Contains(zeichen))
                {
                    return zeichen;
                }
                int position = buchstaben.IndexOf(zeichen);

                int verschluesselt = (position - schluessel) % 26;
                while (verschluesselt < 0)
                {
                    verschluesselt += 26;
                }
                return buchstaben[verschluesselt];

            }

            static string Verschluesseln(string eingabe, string schluessel)
            {
                string buchstaben = "abcdefghijklmnopqrstuvwxyz";
                string ausgabe = "";
                for (int i = 0; i < eingabe.Length; i++)
                {
                    char zeichen = eingabe[i];
                    int zeichenSchluessel = buchstaben.IndexOf(char.ToLower(schluessel[i]));
                    char verschluesselt = BtschftVerschluesseln(zeichen, zeichenSchluessel);
                    ausgabe += verschluesselt;
                }
                return ausgabe;
            }

            static string Entschluesseln(string eingabe, string schluessel)
            {
                string buchstaben = "abcdefghijklmnopqrstuvwxyz";
                string ausgabe = "";
                for (int i = 0; i < eingabe.Length; i++)
                {
                    char zeichen = eingabe[i];
                    int zeichenSchluessel = buchstaben.IndexOf(char.ToLower(schluessel[i]));
                    char verschluesselt = BtschftEntschluesseln(zeichen, zeichenSchluessel);
                    ausgabe += verschluesselt;
                }
                return ausgabe;
            }
        }
    }


}
