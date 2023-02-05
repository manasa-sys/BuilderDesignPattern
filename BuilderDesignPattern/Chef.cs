using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Chef

    {
        IMealbuilder mealbuilder;

        public Chef(IMealbuilder mealbuilder)
        {
            this.mealbuilder = mealbuilder;
        }

        public void PrepareMeal()
        {
            this.mealbuilder.BuildMainItem();
            this.mealbuilder.BuildSideItem();
            this.mealbuilder.BuildDrink();
        }

        public Meal FinalMeal()
        {
            return this.mealbuilder.GetMeal();
        }
    }
}
