using Practice.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class RegisterViewModel
    {

        public List<FormDetail> student { get; set; }

        public List<Cours> Courses { get; set; }

    }
}