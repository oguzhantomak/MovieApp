using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository //Örnek oluşturulamayan, uygulamaya özel tek bir Repository Class'ı
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){
                    Id=1,
                    Name="Bilim Kurgu"

                },
                new Category(){
                    Id=1,
                    Name="Macera"

                },
                new Category(){
                    Id=1,
                    Name="Aksiyon"

                },
                new Category(){
                    Id=1,
                    Name="Dram"

                },
                new Category(){
                    Id=1,
                    Name="Gizem"

                },
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}