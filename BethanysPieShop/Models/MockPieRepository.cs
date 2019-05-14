using System;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "~/images/1.jpg", IsPieOfTheWeek = true, ImageThumbnailUrl = "/images/1.jpg"},
                new Pie {Id = 2, Name = "Orange Pie", Price = 9.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet." , ImageUrl = "~/images/2.jpg",  IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/2.jpg"},
                new Pie {Id = 3, Name = "Carrot Pie", Price = 122.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet." , ImageUrl = "~/images/3.jpg",  IsPieOfTheWeek = true, ImageThumbnailUrl = "/images/3.jpg"},
                new Pie {Id = 4, Name = "Binding Pie", Price = 1552.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "~/images/4.jpg",  IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/4.jpg"},
                new Pie {Id = 5, Name = "Orange Pie", Price = 93.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet." , ImageUrl = "~/images/2.jpg",  IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/2.jpg"},
                new Pie {Id = 6, Name = "Orange Pie", Price = 22.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet." , ImageUrl = "~/images/1.jpg",  IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/1.jpg"}


            };
        }


        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
