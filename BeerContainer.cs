using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beerShop
{
    internal class BeerContainer
    {
        //fields
        string pubName;
        List<Beer> beerList;

        public string PubName
        {
            get;set;
        }
        public List<Beer> BeerList
        {
            get {
                List<Beer> temp=new List<Beer>();
                if (beerList.Count==0)
                {
                    throw new Exception("nincs sör");
                }
                foreach (Beer item in beerList)
                {
                    temp.Add(item);
                }
                return temp;
            }
        }
        public BeerContainer(string name)
        {
            PubName = name;
            beerList = new List<Beer>();
        }
        public void AddBeer(string brand, BeerType bt,int price)
        {
            this.beerList.Add(new Beer(brand, bt, price));
        }

        public Beer this[int index]
        {
            get {
                if (beerList.Count == 0)
                {
                    throw new Exception("nincs sör");
                }
                return beerList[index]; }
            set { beerList[index] = value; }
        }

        public Beer this[string brand]
        {
            get
            {
                if (beerList.Count == 0)
                {
                    throw new Exception("nincs sör");
                }
                foreach (Beer item in beerList)
                {
                    if (item.Brand==brand)
                    {
                        return item;
                    }
                }
                throw new Exception("Nincs ilyen markaju sor.");
            }
        }
    }
}
