using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Meal
    {
        string mainItem;
        string sideItem;
        string drink;

        public Meal(string mainItem, string sideItem, string drink)
        {
            this.mainItem = mainItem;
            this.sideItem = sideItem;
            this.drink = drink;
        }


        public void SetmainItem(string mainItem)
        {
            this.mainItem = mainItem;
        }
        public void SetsideItem(string sideItem)
        {
            this.sideItem = sideItem;
        }
        public void Setdrink(string drink)
        {
            this.drink = drink;
        }
        public string GetmainItem()
        {
            return mainItem;
        }
        public string GetSideItem()
        {
            return sideItem;
        }
        public string GetDrink()
        {
            return drink;
        }
        public void Display()
        {
            Console.WriteLine("Meal: " + this.mainItem + "," + this.sideItem + "," + this.drink);
        }

    }
}