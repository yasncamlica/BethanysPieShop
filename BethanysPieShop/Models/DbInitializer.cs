using System;
using System.Linq;

namespace BethanysPieShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Pies.Any())
            {
                context.AddRange
                    (
                        new Pie { Name = "Apple Pie", Price = 12.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/1.jpg", IsPieOfTheWeek = true, ImageThumbnailUrl = "/images/1.jpg" },
                        new Pie { Name = "Orange Pie", Price = 9.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/2.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/2.jpg" },
                        new Pie { Name = "Carrot Pie", Price = 122.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/3.jpg", IsPieOfTheWeek = true, ImageThumbnailUrl = "/images/3.jpg" },
                        new Pie { Name = "Binding Pie", Price = 1552.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/4.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/4.jpg" },
                        new Pie { Name = "Orange Piee", Price = 93.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/2.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/2.jpg" },
                        new Pie { Name = "Orange Pieee", Price = 22.95M, ShortDescription = "Famous apple pies!", LongDescription = "Icing carrot cake jelly-o cheeecake. Sweet.", ImageUrl = "/images/1.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "/images/1.jpg" }


                    );

                context.SaveChanges();
            }
        }
    }
}
