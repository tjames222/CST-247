using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity3Part1.Models
{
    public class CustomerModel
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerModel(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}