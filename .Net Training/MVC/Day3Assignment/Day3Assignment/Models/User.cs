﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day3Assignment.Models
{
    public class User
    {
        
        

            [Key]

            [DatabaseGenerated(DatabaseGeneratedOption.None)]

            public string UserName { get; set; }

            public string Password { get; set; }

        }
    }

