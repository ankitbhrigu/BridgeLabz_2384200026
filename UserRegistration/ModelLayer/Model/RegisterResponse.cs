﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Model
{
    public class RegisterResponse
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

    }
}