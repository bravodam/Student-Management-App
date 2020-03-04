using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public class Payment
    {
        public int Id {get;set;}
        public int StudentId { get; set; }
        public double AmountPaid { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public DateTime PayDay { get; set; }
        public StudentClass Student { get; set; }

    }
}
