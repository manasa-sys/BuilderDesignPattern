using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    
        public class IndianMealBuilder: IMealbuilder
        {
            Meal meal;
            public IndianMealBuilder()
            {
                meal = new Meal("Biriyani", "chicken65", "pepsi");
            }
            public void BuildDrink()
            {
                Console.WriteLine("Drink is pepsi");
            }

            public void BuildMainItem()
            {
                Console.WriteLine("Main item is Biriyani");
            }

            public void BuildSideItem()
            {
                Console.WriteLine("side item is chicken65");
            }

            public Meal GetMeal()
            {
                return this.meal;
            }
        }
    }

