using FruitStand.Models;
using Microsoft.AspNetCore.Mvc;

namespace FruitStand.Controllers
{
    public class FruitController : Controller
    {
        private readonly IFruitRepository repo;

        public FruitController(IFruitRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var fruit = repo.GetAllFruits();

            return View(fruit);
        }

        public IActionResult ViewFruit(string name)
        {
            var fruit = repo.GetFruit(name);

            return View(fruit);
        }

        public IActionResult UpdateFruit(string name)
        {
            Fruit prod = repo.GetFruit(name);

            if (prod == null)
            {
                return View("FruitNotFound");
            }

            return View(prod);
        }

        public IActionResult UpdateFruitToDatabase(Fruit fruit)
        {
            repo.UpdateFruit(fruit);

            return RedirectToAction("InsertFruit", new { name = fruit.FruitName });
        }

        public IActionResult InsertFruit()
        {
            return View();
        }

        public IActionResult InsertFruitToDatabase(Fruit fruitToInsert)
        {
            repo.InsertFruit(fruitToInsert);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteFruit(Fruit fruit)
        {
            repo.DeleteFruit(fruit);

            return RedirectToAction("Index");
        }

    }
}