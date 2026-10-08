using System.Data;
using MyMVCApp.Model;

namespace MyMVCApp.Repositories
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = new()
        {
                new Category {id =1 , name = "Women", description = "Women jackets"},
                new Category {id =2 , name = "Men", description = "men jackets"},
                new Category {id =3 , name = "Child" , description = "Child jackets"},
                new Category {id =4 , name = "New", description = "New jackets"},
                new Category {id =5 , name = "Home", description = "Home furniture"}
        };

        public static List<Category> GetCategories() => _categories;

        public static void Add(Category category)
        {
            var maxid = _categories.Max(category => category.id);
            category.id = maxid+1;
            _categories.Add(category);
        }

        public static Category? Get(int id)
        {
            var category = _categories?.FirstOrDefault(category => category.id == id);

            if(category !=null)
            {
                return new Category
                {
                    id = category.id,
                    name = category.name,
                    description = category.description
                };
            }
            return null;
        }

        public static void Update(Category category)
        { 
            var categoryItem = _categories.FirstOrDefault(categ => categ.id == category.id);
            if (categoryItem != null)
            {
                categoryItem.name = category.name;
                categoryItem.description = category.description;
                _categories.Add(categoryItem);
            }
        }
    }
}
