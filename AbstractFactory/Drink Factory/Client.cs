using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkFactory.Abstract_products;

namespace DrinkFactory
{
    class Client
    {
        private readonly Lemon _lemons;
        private readonly Beer _Beers;

        public Client(DrinksFactory factory)
        {
            _lemons = factory.CreateLemon();
            _Beers = factory.CreateBeer();
        }

        public string DescribeYourDrinks()
        {
            return $"I can buy: {_lemons.GetType().Name} and {_Beers.GetType().Name}";
        }
    }
}
