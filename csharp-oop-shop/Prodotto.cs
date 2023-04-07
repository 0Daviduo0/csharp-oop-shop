using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        //variabili private per il prodotto
        private int code;
        private string name;
        private string? descr;
        private decimal price;
        private int iva;

        //GET SET
            //code
            public int Code { get { return code; } }
            //name
            public string Name { get { return name; } set { name = value; } }
            //description
            public string? Descr { get { return descr; } set { descr = value; } }
            //price
            public decimal Price { get { return price; } set { price = value; } }
            //iva
            public int Iva { get { return iva; } }

        //assegnazione caratteristiche variabili prodotto (nome, descrizione e prezzo)
        public Prodotto(string name, string descr, decimal price)
        {

            code = new Random().Next(1, 100000);  //non modificabile
            Name = name;
            Descr = descr;
            Price = price;
            iva = 22; //non modificabile

        }

        public decimal PriceTaxed()
        {
            decimal priceWiva = Price + ( (Price * Iva) / 100 ); //calcolo del prezzo con iva
            return priceWiva;
        }

        public void CodedName()
        {
            Console.WriteLine($"{code} - {Name}"); //nome prodotto con codice
        }

        public void CodeZeros()
        {
            Console.Write(code.ToString().PadLeft(8, '0') + " <--codice con degli 0 per arrivare a 8 cifre\n");
        }

    }
}

