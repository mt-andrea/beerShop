using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beerShop
{
    internal class BeerShop
    {
        static void ReadFile(string fileName, BeerContainer pub)
        {
            StreamReader sr = new StreamReader(fileName, Encoding.Default);
            sr.ReadLine();
            string[] data;
            while (!sr.EndOfStream)
            {
                data = sr.ReadLine().Split(';');
                pub.AddBeer(
                    data[0],
                    (BeerType)Enum.Parse(typeof(BeerType), data[1]),
                    int.Parse(data[2]));
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            BeerContainer kocsma = new BeerContainer("ÜVEGTIGRIS");
            ReadFile("beer.csv", kocsma);
            foreach (Beer item in kocsma.BeerList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
