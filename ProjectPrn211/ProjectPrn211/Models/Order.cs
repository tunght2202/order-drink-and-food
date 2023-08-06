using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn211.Models
{
    public class Order
    {
        public string tableName { set; get; }
        public string foodOrDrinkName { set; get; }
        public int number { set; get; }
        public int status { set; get; }
        public int id { set; get; }
    }
}
