using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
namespace Persistence
{
    public class  Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
            {
              new Post {
                Title = "MOMO",
                Date = DateTime.Now.AddDays(-10),
                Body = " It's a dumpling filled with meat or vegetables as well. It is eaten with tomato pickle "
              },
              new Post {
                Title = "Key lime pie.",
                Date = DateTime.Now.AddDays(-7),
                Body = "originating the concoction of key lime juice, sweetened condensed milk, and egg yolks, which could be cooked (by a thickening chemical reaction of the ingredients) at sea.."
              },
              new Post {
                Title = "GORP",
                Date = DateTime.Now.AddDays(-4),
                Body = "Add all the granola, seeds, nuts, dried fruit, candied ginger, and M&Ms you want"
              }
            };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
} 
    
