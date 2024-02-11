namespace LA1303
{
    internal class Program
    {

        static string nochmals="Ja";
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Vig vig = new Vig();
                    ROT rot = new ROT();
                    Sub sub = new Sub();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wilkommen bei der Verschlüsselungsapp!");
                    Console.WriteLine("Arten: Vigenere[1] / ROT13[2] / Substitution[3] ");
                    Console.WriteLine("Welche Verschlüsselungsart möchten Sie anwenden?");
                    int antwort = Convert.ToInt32(Console.ReadLine());

                    switch (antwort)
                    {
                        case 1:
                            vig.Vign();
                            break;
                        case 2:
                            rot.Rot();
                            break;
                        case 3:
                            sub.Subs();
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe");
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Möchten Sie nochmals eine Botschaft ver- oder entschlüsseln? [Ja] / [Nein]");
                    string nochmal = Console.ReadLine();
                    if (nochmal == "Nein")
                    {
                        break;
                    }
                } while (nochmals == "Ja");
               
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe!");
            }


        }
    }
}