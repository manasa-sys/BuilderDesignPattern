using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class CanadianMealBulder : IMealbuilder
    {
        Meal meal;
        public CanadianMealBulder()
        {
            meal = new Meal("Burger","frites","pepsi");
        }
        public void BuildDrink()
        {
            Console.WriteLine("Drink is pepsi");
        }

        public void BuildMainItem()
        {
            Console.WriteLine("Main item is burger");
        }

        public void BuildSideItem()
        {
            Console.WriteLine("side item is frites");
        }

        public Meal GetMeal()
        {
           return this.meal;
        }
    }
}
