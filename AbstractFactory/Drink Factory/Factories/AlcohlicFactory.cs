using DrinkFactory.Abstract_products;
using DrinkFactory.Products;

namespace DrinkFactory.Factories
{
    class AlcoholicFactory : DrinksFactory
    {
        public override Lemon CreateLemon()
        {
            return new VodkaLemon();
        }

        public override Beer CreateBeer()
        {
            return new Amstel();
        }
    }
}
