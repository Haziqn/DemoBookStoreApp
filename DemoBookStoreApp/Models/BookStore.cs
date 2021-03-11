using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoBookStoreApp.Models
{
    public class BookStore
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public Author Author { get; set; }
        public Publisher Pubisher { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }

    }
}