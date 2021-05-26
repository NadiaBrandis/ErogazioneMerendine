using System;
using System.Collections.Generic;

namespace ErogazioneMerendine
{
    class Program
    {
        static void Main(string[] args)
        {
            var merendine = new Dictionary<string, double>();
            var selezione = new Dictionary<string,string>();
            merendine.Add("Patatine", 0.80);
            merendine.Add("Buondi", 2.10);
            merendine.Add("Duplo", 1.50);
            merendine.Add("Croccantelle", 0.50);
            selezione.Add("1", "Patatine");
            selezione.Add("2", "Buondi");
            selezione.Add("3", "Duplo");
            selezione.Add("4", "Croccantelle");

            string scelta;

            do
            {
                Console.WriteLine("SCEGLI LE TUA MERENDA");
                Console.WriteLine("1. Patatine:0,80 Euro");
                Console.WriteLine("2. Buondì:2,10 Euro");
                Console.WriteLine("3. Duplo:1,50 Euro");
                Console.WriteLine("4. Croccantelle:0,50 Euro");
                Console.WriteLine("digita 0 per uscire!!");

                double denaro = 0;
                scelta = Console.ReadLine();
                string prodotto = selezione[scelta];

                double prezzo = merendine[prodotto];
                
                double costo = denaro - prezzo;

                switch (scelta)
                {
                    case "1":

                        SceltaProdotto(scelta, merendine, selezione);
                        Pagamento(prezzo, denaro, costo);
                       break;
                    case "2":
                        SceltaProdotto(scelta, merendine, selezione);
                        Pagamento(prezzo, denaro, costo);
                        break;
                    case "3":
                        SceltaProdotto(scelta, merendine, selezione);
                        Pagamento(prezzo, denaro, costo);
                        break;
                    case "4":
                        SceltaProdotto(scelta, merendine, selezione);
                        Pagamento(prezzo, denaro, costo);
                        break;
                }

            } while (scelta !="0");
        }

        private static void Pagamento(double prezzo,  double denaro,double costo)
        {
            if (costo == 0)
            {
                Console.WriteLine("Ritira la tua merenda");
            }
            if (costo > 0)
            {
                Console.WriteLine($"Ritira la merenda e il resto di {costo} Euro");
            }
            else
            {
                while (costo < 0)
                {
                    Console.WriteLine("Inserisci Denaro");
                    denaro = double.Parse(Console.ReadLine());
                    costo = costo + denaro + 0.1;
                }
                Console.WriteLine($"ritira la tua merenda e il tuo resto :{costo} euro");
            }

        }

        private static void SceltaProdotto(string scelta, Dictionary<string, double> merendine , Dictionary<string, string> selezione)
        {

            Console.WriteLine("--------------");
            Console.WriteLine($"HAI SELEZIONATO {selezione[scelta]}");

            string prodotto = selezione[scelta];

            double prezzo = merendine[prodotto];

            Console.WriteLine($"inserisci {merendine[prodotto]} Euro per avere {selezione[scelta]}");
        }
    }
}
