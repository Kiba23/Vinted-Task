
namespace DiscountEvaluator.Models
{
    class Pricing
    {
        public Sizes Size { get; set; }
        public Companies Company { get; set; }
        public decimal Price { get; set; }

        public Pricing(Companies company, Sizes size, decimal price)
        {
            Company = company;
            Size = size;
            Price = price;
        }
    }
}
