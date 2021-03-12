using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoBookStoreApp.Models
{
    public class Books
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Pubisher { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}