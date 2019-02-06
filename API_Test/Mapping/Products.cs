using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Test.Mapping
{
    public class Products
    {
        public int id { get; set; }
        public int position { get; set; }
        public string name { get; set; }
    }

   public class Parts
    {
        public int id { get; set; }
        public int product { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}