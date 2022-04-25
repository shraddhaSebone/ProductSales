using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class MobilesData
    {
        public int mobileId { get; set; }
        public string mobileName { get; set; }
        public int mobilePrice { get; set; }
        public int mobileQuantity { get; set; }
        public int pinCode { get; set; }
        public DateTime dateTime { get; set; }
        public MobilesData() { }
        public MobilesData(int mobileId, string mobileName, int mobilePrice, int mobileQuantity, int pinCode, DateTime dateTime)
        {
            this.mobileId = mobileId;
            this.mobileName = mobileName;
            this.mobilePrice = mobilePrice;
            this.mobileQuantity = mobileQuantity;
            this.pinCode = pinCode;
            this.dateTime = dateTime;
        }
    }
}
