using FruitStand.Models;

namespace FruitStand
{
    public interface IFruitRepository
    {
        public IEnumerable<Fruit> GetAllFruits();
        public Fruit GetFruit(string name);
        public void UpdateFruit(Fruit fruit);
        public void InsertFruit(Fruit fruitToInsert);
        public void DeleteFruit(Fruit fruit);
    }
}
