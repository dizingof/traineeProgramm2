using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name ="Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage ="Длинна имени не менее 5 символов")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна фамилии не менее 5 символов")]
        public string SurName { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна Адрес не менее 5 символов")]
        public string Adress { get; set; }
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна номера телефона не менее 5 символов")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна emeil не менее 5 символов")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
