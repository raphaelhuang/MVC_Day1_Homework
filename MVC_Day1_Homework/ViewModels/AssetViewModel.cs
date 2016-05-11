using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day1_Homework.ViewModels
{
    public class AssetViewModel
    {
        [Required]
        public int Category { get; set; }
       
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "請輸入正整數")]
        public decimal Money { get; set; }

        [Required]
        [Remote("Index", "Valid", ErrorMessage = "日期不得大於今天")]
        public DateTime Date { get; set; }
        
        [Required]
        [MaxLength(100, ErrorMessage = "最多輸入100個字元")]
        public string Description { get; set; }

    }
}