namespace FruitStand.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int StockLevel { get; set; }

        public Fruit()
        {

        }
    }
}
