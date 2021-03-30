using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        [Display(Name = "Ad")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen Adresinizi Girin")]
        [Display(Name = "Adres")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir i Girin")]
        [Display(Name = "Şehir")]
        public string City { get; set; }

        [Required(ErrorMessage = "Lütfen Ülke Girin")]
        [Display(Name = "Ülke")]
        [StringLength(50)]
        public string State { get; set; }

        [Required(ErrorMessage = "Lütfen Posta Kodunu Girin")]
        [Display(Name = "Posta Kodu")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Lütfen Telefonu Girin")]
        [Display(Name = "Telefon No")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
