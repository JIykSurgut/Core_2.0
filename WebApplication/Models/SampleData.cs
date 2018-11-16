
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public static class SampleData
    {
        public static void Initialize(DataBaseContext context)
        {
            if (!context.Article.Any())
            {
                context.Article.AddRange(
                    new Article
                    {
                        Title = "Статья 1",
                        Content = "Содержание статьи 1",
                        DateInsert = DateTime.Now,
                        DateUpdate = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
