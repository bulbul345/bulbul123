﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.ViewModels
{
    public class LoginViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
       
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string ContactNumber { get; set; }
    }
}
