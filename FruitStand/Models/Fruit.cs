namespace FruitStand.Models
{
    public class Fruit
    {
        public Fruit() { }
        //property names have to be same names as database
        public string? FruitName { get; set; }
        public double Price { get; set; }
        public int StockLevel { get; set; }
    }
}
