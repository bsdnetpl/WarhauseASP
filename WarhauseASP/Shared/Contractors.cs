using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhauseASP.Shared
{
    public class Contractors
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; }= string.Empty; 
        public string Phone { get; set; } = string.Empty;
        public string Representative{ get; set; } = string.Empty;
        public string Recipient { set; get; } = string.Empty;
        public string NIP { get; set; } = string.Empty;
    }
}
