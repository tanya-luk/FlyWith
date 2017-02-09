﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyWith.Models
{
    public class MealType
    {
        public int MealTypeID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PersonalDetails> PersonalDetails { get; set; }
    }
}
