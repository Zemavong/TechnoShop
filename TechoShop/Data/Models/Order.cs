using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechnoShop.Data.Models;

namespace TechnoShop.Data.Mocks
{
    public class Order
    {
  
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите почту")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Некорректные данные")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime   { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
