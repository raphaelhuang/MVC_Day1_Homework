namespace MVC_Day1_Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;
    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        [Required]
        public int Categoryyy { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "請輸入正整數")]
        public int Amounttt { get; set; }

        [Required]
        [Remote("Index", "Valid", ErrorMessage = "日期不得大於今天")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        [MaxLength(100, ErrorMessage = "最多輸入100個字元")]
        public string Remarkkk { get; set; }
    }
}
