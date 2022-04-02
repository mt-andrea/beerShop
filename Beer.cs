using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beerShop
{
    internal class Beer
    {
        //fields
        static int ID = 1;
        int id;
        string brand;
        BeerType type;
        int price;

        public int Id
        {
            get { return id; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Az azonosító nem lehet 0 vagy attól kisebb!");
                }
                if (value >= 100)
                {
                    throw new Exception("Az azonosító nem lehet 100 vagy attól nagyobb!");
                }
                else
                {
                    this.id = value;
                }

            }
        }
        public string Brand
        {
            get { return brand; }
            set {
                if (value.Length < 3)
                {
                    throw new Exception("A márka nem lehet rövidebb 3 karakternél!");
                }
                else { brand = value; }
            }
        }
        public BeerType Type{ set { type = value; } get { return type; } }

        public int getPrice() { return price; }
        public void setPrice(int price) {
            if (price<=0)
            {
                throw new Exception("Fizetsz, hogy igyak?");
            }
            if (price>1000)
            {
                throw new Exception("Túl árazott sör!");
            }
            this.price = price;
        }

        private Beer() {
            Id = ID++;
        }
        public Beer(string brand, BeerType type, int price) : this() {
            Brand = brand;
            Type = type;
            setPrice(price) ;
        }
        public override string ToString()
        {
            return $"ID: {id}\nMárka: {this.brand}\nTípus: {this.type}\nÁr: {this.price}";
        }
    }
}
