using System.ComponentModel.DataAnnotations;

namespace WarhauseASP.Shared
{
    public class Invoce
    {
        [Key]
        public Guid id { get; set; }
        public string NumberInvoce { get; set; } = string.Empty;
        public string NipCustomer { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public double PriceNetto { get; set; }
        public double PriceBrutto { get; set; }
        public double Tax { get; set; }
        public string TimePayment { get; set; } = string.Empty;
        public string GTU { get; set; }


    }
}
