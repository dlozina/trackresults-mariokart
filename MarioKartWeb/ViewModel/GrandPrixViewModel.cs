﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class GrandPrixViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}