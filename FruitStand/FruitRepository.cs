using Dapper;
using FruitStand.Models;
using System.Data;

namespace FruitStand
{
    public class FruitRepository : IFruitRepository
    {
        private readonly IDbConnection _conn;

        public FruitRepository(IDbConnection conn)
        {
             _conn = conn;
        }

        public IEnumerable<Fruit> GetAllFruits()
        {
             return _conn.Query<Fruit>("SELECT * FROM FRUITS;");
        }

        public Fruit GetFruit(string name)
        {
             return _conn.QuerySingle<Fruit>("SELECT * FROM FRUITS WHERE FRUITNAME = @name",
                new { name = name });
        }

        public void UpdateFruit(Fruit fruit)
        {
            _conn.Execute("UPDATE fruits SET FruitName = @name, Price = @price WHERE FruitName = @name",
               new { name = fruit.FruitName, price = fruit.Price });
        }

        public void InsertFruit(Fruit fruitToInsert)
        {
            _conn.Execute("INSERT INTO fruits (FRUITNAME, PRICE, STOCKLEVEL) VALUES (@name, @price, @stocklevel);",
                new { name = fruitToInsert.FruitName, price = fruitToInsert.Price, stocklevel = fruitToInsert.StockLevel});
        }

        public void DeleteFruit(Fruit fruit)
        {
            _conn.Execute("DELETE FROM fruits WHERE FruitName = @name;",
                                       new { name = fruit.FruitName });
        }

    }
}