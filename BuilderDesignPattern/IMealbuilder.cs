using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IMealbuilder
    {
        void BuildMainItem();
        void BuildSideItem();
        void BuildDrink();

        Meal GetMeal();

    }
}
