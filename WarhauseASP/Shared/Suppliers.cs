using System.ComponentModel.DataAnnotations;

namespace WarhauseASP.Shared
{
    public class Suppliers
    {
        [Key]
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierState { get; set; }
        public string SupplierZipCode { get; set; }
        public string SupplierCountry { get; set; }
        public string NIP { get; set; }
        public string NumberInvoce { get; set; }
        public DateTime dateTime { get; set; }
        public double Netto { get; set; }
        public double Brutto { get; set; }
        public double Tax { get; set; }
        public int UnitTax { get; set; }

    }
}
