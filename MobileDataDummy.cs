using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class MobileDataDummy
    {
        public List<MobilesData> getMobileData()
        {
            List<MobilesData> list = new List<MobilesData>();
            MobilesData mobilesData1 = new MobilesData(101,"iphone", 40000,2,451001,new DateTime(2022,4,12));
            MobilesData mobilesData2 = new MobilesData(102, "Samsung", 20000, 2, 451002, new DateTime(2022, 4, 12));
            MobilesData mobilesData3 = new MobilesData(101, "iphone", 60000, 2, 451003, new DateTime(2022, 8, 1));
            MobilesData mobilesData4 = new MobilesData(101, "iphone", 45000, 2, 451004, new DateTime(2022, 12, 13));
            MobilesData mobilesData5 = new MobilesData(104, "Vivo", 18000, 2, 451004, new DateTime(2022, 8, 19));
            MobilesData mobilesData6 = new MobilesData(102, "Samsung", 29000, 2, 451002, new DateTime(2022, 5, 25));
            MobilesData mobilesData7 = new MobilesData(103, "Oppo", 55000, 2, 451001, new DateTime(2022, 10, 28));
            MobilesData mobilesData8 = new MobilesData(101, "iphone", 80000, 2, 451002, new DateTime(2022, 3, 6));
            MobilesData mobilesData9 = new MobilesData(103, "Oppo", 33000, 2, 451003, new DateTime(2022, 7, 5));
            MobilesData mobilesData10 = new MobilesData(101, "iphone", 72000, 2, 451004, new DateTime(2022, 6, 15));
            list.Add(mobilesData1);
            list.Add(mobilesData2);
            list.Add(mobilesData3);
            list.Add(mobilesData4);
            list.Add(mobilesData5);
            list.Add(mobilesData6);
            list.Add(mobilesData7);
            list.Add(mobilesData8);
            list.Add(mobilesData9);
            list.Add(mobilesData10);

            return list;
        }
    }
}
