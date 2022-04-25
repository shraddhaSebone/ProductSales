using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class AggregationOperations
    {
        public List<TotalSalesById> getTotalMobileSalesById(List<MobilesData> list)
        {
            Dictionary<int, TotalSalesById> key = new Dictionary<int, TotalSalesById>();
            List<TotalSalesById> resultList = new List<TotalSalesById>();
            foreach (MobilesData data in list)
            {
                if (key.ContainsKey(data.mobileId))
                {
                    key[data.mobileId].id = data.mobileId;
                    key[data.mobileId].name = data.mobileName;
                    key[data.mobileId].total = data.mobilePrice;
                }
                else
                {
                    key.Add(data.mobileId, new TotalSalesById());
                    key[data.mobileId].id = data.mobileId;
                    key[data.mobileId].name = data.mobileName;
                    key[data.mobileId].total = data.mobilePrice;
                }
            }
                foreach (TotalSalesById data1 in key.Values)
                {
                    resultList.Add(data1);
                }
                return resultList;

        }

        public List<TotalSalesByPinCode> gettotalsalesmobilesgroupbypincode(List<MobilesData> list)
          {
            Dictionary<int, TotalSalesByPinCode> key = new Dictionary<int, TotalSalesByPinCode>();
            List<TotalSalesByPinCode> resultlist = new List<TotalSalesByPinCode>();
            foreach(MobilesData data in list)
            {
               if (key.ContainsKey(data.pinCode))
               {
                     key[data.pinCode].total = data.mobilePrice;
                     key[data.pinCode].pinCode = data.pinCode;
                     key[data.pinCode].count++;
               }
               else
               {
                    key.Add(data.pinCode,new TotalSalesByPinCode());
                    key[data.pinCode].total = data.mobilePrice;
                    key[data.pinCode].pinCode = data.pinCode;
                    key[data.pinCode].count = 1;
               }
            }
             foreach(TotalSalesByPinCode data1 in key.Values)
             {
               resultlist.Add(data1);
             }
             return resultlist;
        }
        
    }
}
