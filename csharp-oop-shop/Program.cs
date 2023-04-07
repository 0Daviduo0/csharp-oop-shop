using System.Net.Http.Headers;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto nuovoProdotto = new Prodotto("Fortnite gift-card", "scala muro scala muro, Kekko pusha", 25);
            Console.WriteLine("-------------PRODOTTI------------- \n");
            //esecuzione funzioni per avere il nome del prodotto e per avere il prezzo tassato
            nuovoProdotto.CodedName();
            Console.WriteLine("info --> " + nuovoProdotto.Descr);
            Console.WriteLine("prezzo --> " + nuovoProdotto.Price + "$");
            Console.WriteLine("Prezzo con iva --> " + nuovoProdotto.PriceTaxed() + "$");

        }
    }
}