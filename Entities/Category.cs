﻿using System.ComponentModel.DataAnnotations;

namespace LibraryMgmtSystem.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
