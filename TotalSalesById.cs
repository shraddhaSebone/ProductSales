using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDataAssignment
{
    internal class TotalSalesById
    {
        public int id { get; set; }
        public string name { get; set; }
        public int total { get; set; }  
        public TotalSalesById() { }
        public TotalSalesById(int id, string name, int total)
        {
            this.id = id;
            this.name = name;
            this.total = total;
        }
    }
}
