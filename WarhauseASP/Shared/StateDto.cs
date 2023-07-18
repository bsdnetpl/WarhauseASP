using System.ComponentModel.DataAnnotations;

namespace WarhauseASP.Shared
{
    public class StateDto
    {
        [Required]
        [StringLength(3, ErrorMessage = "Name is too long.")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string EAN { get; set; } = string.Empty;
        [Required]
        public double PurchasePriceNetto { get; set; }
        [Required]
        public double SellePriceBrutto { get; set; }
        [Required]
        public string GTU { get; set; } = string.Empty;
        [Required]
        public double Quantity { get; set; }
        public double Profit { get; set; }
        [Required]
        public double QuantityInBox { get; set; }
        [Required]
        public string InvoiceNumber { get; set; }
        public double CourseEuro { get; set; }
        public double CourseUsd { get; set; }
        [Required]
        public double TaxVat { get; set; }
        public string Daty_Bay { get; set; }
        public double DifferendVatTax { get; set; }
        public string CodProduct { get; set; } = null!;
    }
}
