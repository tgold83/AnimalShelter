using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class GroupsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public GroupsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
    //   List<Animal> model = _db.Animals.ToList();
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details(int id)
    {
        Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
        return View(thisAnimal);
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  }
}