using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Canadian Menu");

            IMealbuilder imealbuilder=new CanadianMealBulder();
            Chef chef = new Chef(imealbuilder);
            chef.PrepareMeal();
            chef.FinalMeal().Display();

            Console.WriteLine("Indian Menu");

            IMealbuilder ibuilder = new IndianMealBuilder();
            Chef chef1=new Chef(ibuilder);
            chef1.PrepareMeal();
            chef1.FinalMeal().Display();

        }
    }
}
