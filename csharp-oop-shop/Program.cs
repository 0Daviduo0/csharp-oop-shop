using csharp_oop_shop;
using System.Net.Http.Headers;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto[] listaProdotti = new Prodotto[]
                {
                    new Prodotto("Fortnite gift-card", "scala muro scala muro, Kekko pusha", 22),
                    new Prodotto("Elder Ringo", "Ringo Sambuco, in collab con Elder Ringo", 30),
                    new Prodotto("Gamergirl bath water", "prodotto non adatto ai minori di 16 anni", 155),
                    new Prodotto("Mouse della trust", "incredibile qualit- ah no", 8),
                    new Prodotto("Playstation gift-card", "altro modo per comprare i v-bucks di fortnite", 22),
                    new Prodotto("Droga sintentica", "Perchè c'è questo prodotto, wtf", 28),
                };
            

                foreach (var prodotto in listaProdotti)
                    {
                        Console.WriteLine("\n--------------------------PRODOTTO--------------------------");
                        //esecuzione funzioni per avere il nome del prodotto e per avere il prezzo tassato
                        prodotto.CodedName();
                        Console.WriteLine("info --> " + prodotto.Descr);
                        Console.WriteLine("prezzo --> " + prodotto.Price + "$");
                        Console.WriteLine("Prezzo con iva --> " + prodotto.PriceTaxed() + "$");
                        Console.WriteLine("------------Parte BONUS------------");
                        prodotto.CodeZeros();
            }



        }


    }
}
    


