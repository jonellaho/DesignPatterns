using DrinkFactory.Abstract_products;
using DrinkFactory.Products;

namespace DrinkFactory
{
    abstract class DrinksFactory
    {
        public abstract Lemon CreateLemon();
        public abstract Beer CreateBeer();
    }
}
