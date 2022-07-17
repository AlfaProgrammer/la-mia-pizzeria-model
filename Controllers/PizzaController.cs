using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using (PizzasContext pizzaDB = new PizzasContext())
            {
                List<PizzaModel> pizzasList = pizzaDB.Pizzas.ToList();
                return View(pizzasList);
            }

        }

        public IActionResult Details(int id)
        {
            using (PizzasContext pizzaDB = new PizzasContext())
            {
                var pizza = pizzaDB.Pizzas.Where(pizza => pizza.Id == id).First();

                return View(pizza);
            }
        }
    }

}
