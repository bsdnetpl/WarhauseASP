namespace WarhauseASP.Shared
{
    public class State
    {
        public Guid Id { get; set; }
        public int Ids { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string EAN { get; set; } = string.Empty;
        public double PurchasePriceNetto { get; set; }
        public double SellePriceBrutto { get; set; }
        public string GTU { get; set; } = string.Empty;
        public double Quantity { get; set; }
        public double Profit { get; set; }
        public double QuantityInBox { get; set; }
        public string InvoiceNumber { get; set; }
        public double CourseEuro { get; set; }
        public double CourseUsd { get; set; }
        public string TaxVat { get; set; }
        public string Daty_Bay { get; set; }
        public double DifferendVatTax { get; set; }
        public string CodProduct { get; set; } = null!;
    }
}
