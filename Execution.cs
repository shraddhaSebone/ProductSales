using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            MobileDataDummy mobileDataDummy = new MobileDataDummy();
            List<MobilesData>  list = mobileDataDummy.getMobileData();

            foreach(MobilesData mobileData in list)
            {
                Console.WriteLine($"{mobileData.mobileId},{mobileData.mobileName},{mobileData.mobilePrice},{mobileData.mobileQuantity},{mobileData.pinCode},{mobileData.dateTime.ToLongDateString()}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            AggregationOperations aggregationOperations = new AggregationOperations();
            List<TotalSalesById> list1 = aggregationOperations.getTotalMobileSalesById(list);
            foreach(TotalSalesById data in list1)
            {
                Console.WriteLine($"{data.id},{data.name},{data.total}");
            }
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------");

            List<TotalSalesByPinCode> list2 = aggregationOperations.gettotalsalesmobilesgroupbypincode(list);
            foreach(TotalSalesByPinCode data in list2)
            {
                Console.WriteLine($"{data.pinCode},{data.count},{data.total}");
            }
        }
    }
}
