﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Models
{
    public class Role
    {
      
        [Required]
       
        public string RoleName { get; set; }
        
    }
}