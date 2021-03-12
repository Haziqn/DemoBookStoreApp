using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoBookStoreApp.Models
{
    public class BookOrder
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int cardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CVV { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string zipCode { get; set; }
        public string AddressLine { get; set; }
    }
}