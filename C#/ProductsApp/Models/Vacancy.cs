using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProductsApp.Models
{
    public class Vacancy
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string SkillsRequired { get; set; }
        
    }
}