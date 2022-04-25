using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class TotalSalesByPinCode
    {
        public int pinCode { get; set; }
        public int count { get; set; }
        public int total { get; set; }
        public TotalSalesByPinCode() {}
        public TotalSalesByPinCode(int pinCode,int count,int total)
        {
            this.pinCode = pinCode;
            this.count = count;
            this.total = total;
        }
    }
}
