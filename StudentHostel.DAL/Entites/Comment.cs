﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostel.DAL.Entites
{
    public class Comment
    {
        [Key]
        public int Comment_ID { get; set; }
        public required string Comment_Text { get; set; }

    }
}
