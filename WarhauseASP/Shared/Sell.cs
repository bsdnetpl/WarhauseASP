namespace WarhauseASP.Shared
{
    public class Sell
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EAN { get; set; } = string.Empty;
        public double PurchasePriceNetto { get; set; }
        public double SellePriceBrutto { get; set; }
        public string GTU { get; set; } = string.Empty;
        public double Quantity { get; set; }
        public double Profit { get; set; }
        public DateTime dateTimeSell { get; set; }

    }
}
