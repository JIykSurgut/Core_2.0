using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }

        public DbSet<Article> Article { get; set; }
    }

    public class Article
    {
        public int ArticleId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        [Required]
        public DateTime DateInsert { get; set; }
        [Required]
        public DateTime DateUpdate { get; set; }
    }

    
}