﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApi.Models
{
    public partial class AddMovie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
    }
}
