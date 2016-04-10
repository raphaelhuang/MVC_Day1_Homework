using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day1_Homework.ViewModels
{
    public class AssetViewModel
    {
        public bool Category { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}