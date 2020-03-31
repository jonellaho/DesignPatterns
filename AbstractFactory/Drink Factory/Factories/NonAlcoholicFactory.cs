using DrinkFactory.Abstract_products;
using DrinkFactory.Products;

namespace DrinkFactory.Factories
{
    class NonAlcoholicFactory : DrinksFactory
    {
        public override Lemon CreateLemon()
        {
            return new SodaLemon();
        }

        public override Beer CreateBeer()
        {
            return new ElbarNoAlchool();
        }
    }
}
