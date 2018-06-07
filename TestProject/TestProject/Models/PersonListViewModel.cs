using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class PersonListViewModel
    {
        public List<PersonViewModel> People { get; set; }
        public int TotalPeople { get; set; }
    }
}