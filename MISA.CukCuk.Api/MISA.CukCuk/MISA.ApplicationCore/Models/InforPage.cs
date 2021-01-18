using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Models
{
    public class InforPage
    {
        public IEnumerable<Customer> customers{ get; set; }
        public int counts { get; set; }
       
        public InforPage(IEnumerable<Customer> customers, int counts)
        {
            this.customers = customers;
            this.counts = counts;
        }
    }
}
