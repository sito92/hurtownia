using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Hurtownia.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nazwa produktu")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Jednostka")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Musisz podać konkretną jednostkę")]
        public int UnitId { get; set; }

        [Required]
        [Display(Name = "Typ produktu")]
        [Range(1,Int32.MaxValue,ErrorMessage = "Musisz podać konkretny typ")]
        public int ProductTypeID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data ważności")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Cena")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Ilość")]
        public int Amount { get; set; }


        public virtual ProductType ProductType { get; set; }
        public virtual Unit Unit { get; set; }

    }
}