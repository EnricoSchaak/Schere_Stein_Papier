namespace SSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int anzahlSiege = 1;
            bool nochmal = true;


            while (anzahlSiege < 3 && nochmal == true)
            {


                int computerAuswahl = r.Next(1, 4);

                //Stein = 1
                //Papier = 2
                //Schere = 3
                string userName = Environment.UserName;
                Console.WriteLine($"Hallo und Willkommen {Environment.UserName} bei dem Schere, Stein, Papier - Simulator.");
                Console.WriteLine("Gib bitte deine Auswahl ein: Stein, Schere oder Papier");
                var spielerAuswahl = Console.ReadLine().ToLower();

                if (computerAuswahl == 1) //Stein
                {
                    if (spielerAuswahl == "stein")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Unentschieden");
                    }
                    else if (spielerAuswahl == "schere")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine("Du hast Verloren!");
                    }
                    else if (spielerAuswahl == "papier")
                    {
                        Console.WriteLine("Der Computer hat Stein gewählt!");
                        Console.WriteLine($"Du hast gewonnen. Du hast bisher {anzahlSiege} Punkte");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe war ungültig. Wähle bitte Schere, Stein oder Papier!");
                    }
                }
                else if (computerAuswahl == 2) //Papier
                {
                    if (spielerAuswahl == "papier")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt.");
                        Console.WriteLine("Unentschieden");
                    }
                    else if (spielerAuswahl == "stein")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt.");
                        Console.WriteLine("Du hast verloren.");
                    }
                    else if (spielerAuswahl == "schere")
                    {
                        Console.WriteLine("Der Computer hat Papier gewählt.");
                        Console.WriteLine($"Du hast gewonnen. Du hast bisher {anzahlSiege} Punkte");
                        anzahlSiege = anzahlSiege + 1;

                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe war ungültig. Wähle bitte Schere, Stein oder Papier!");
                    }
                }
                else if (computerAuswahl == 3) //Schere
                {
                    if (spielerAuswahl == "schere")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt.");
                        Console.WriteLine("Unentschieden");
                    }
                    else if (spielerAuswahl == "papier")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt.");
                        Console.WriteLine("Du hast verloren.");
                    }
                    else if (spielerAuswahl == "stein")
                    {
                        Console.WriteLine("Der Computer hat Schere gewählt.");
                        Console.WriteLine($"Du hast gewonnen. Du hast bisher {anzahlSiege} Punkte");
                        anzahlSiege = anzahlSiege + 1;
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe war ungültig. Wähle bitte Schere, Stein oder Papier!");
                    }
                }
                
                Console.WriteLine("Wenn du das Spiel abbrechen möchtest schreibe E(x)it, wenn nicht tippe einfach Enter.");
                string eingabe = Console.ReadLine().ToLower().Trim();

                if (eingabe == "exit" || eingabe == "x")
                {
                    nochmal = false;
                }
            }
        }
    }
}
