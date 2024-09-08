using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data;
using SuperMarket.Data.Repository.IRepository;
using SuperMarket.Models;

namespace SuperMarket.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly ICategoryRepository _categoryRepo;

        public CategoriesController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _categoryRepo.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "add";
            return View();
            
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Add(category);
                _categoryRepo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category categoryFromDb = _categoryRepo.Get(u=>u.Id == id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }
            ViewBag.Action = "edit";
            return View(categoryFromDb);

        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Update(category);
                _categoryRepo.Save();
                return RedirectToAction("Index");
            }
            return View(category);

        }

        public IActionResult Delete(int id)
        {
            Category obj = _categoryRepo.Get(u=> u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _categoryRepo.Remove(obj);
            _categoryRepo.Save();
            return RedirectToAction("Index");
        }


    }
}
