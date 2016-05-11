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
        [Range(0, int.MaxValue, ErrorMessage = "�п�J�����")]
        public int Amounttt { get; set; }

        [Required]
        [Remote("Index", "Valid", ErrorMessage = "������o�j�󤵤�")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        [MaxLength(100, ErrorMessage = "�̦h��J100�Ӧr��")]
        public string Remarkkk { get; set; }
    }
}
