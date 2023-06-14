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
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; }= string.Empty; 
        public string Phone { get; set; }
        public string Representative{ get; set; }
        public string Recipient { set; get; } = string.Empty;
        public string NIP { get; set; }
    }
}
