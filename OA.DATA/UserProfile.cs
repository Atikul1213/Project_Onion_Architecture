﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DATA
{
    public class UserProfile : BaseEntity
    {
         
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Address { get; set; }

        public virtual User User { get; set; }
       
    }
}