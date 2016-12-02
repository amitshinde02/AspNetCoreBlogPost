﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBlogPost.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        [DisplayAttribute(Name = "Category Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
