using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Model;
using MyMVCApp.Repositories;

namespace MyMVCApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        //public IActionResult Edit(int id)
        //{
        //    _categoryRepository?.get
        //}

        //public IActionResult add(int Id)
        //{
        //    Category cate = new Category();
        //    cate.id = 7;
        //    cate.name = "latest";
        //    _categories.Add(cate);

        //    return View("Index");
        //}
        public IActionResult Edit([FromRoute]int id)
        {
            var category = CategoryRepository.Get(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.Update(category);

                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid && category.id !=0)
            {
                CategoryRepository.Add(category);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(category);
        }

    }
}
