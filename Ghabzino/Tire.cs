using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghabzino
{
    public class Parameter
    {
        public int sellPrice { get; set; }
        public int id { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string productContent { get; set; }
        public int productType { get; set; }
        public int volume { get; set; }
        public List<Pic> pics { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string skuSamt { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public int producerName { get; set; }
        public string totalQty { get; set; }
        public object total { get; set; }
    }

    public class Pic
    {
        public string pic { get; set; }
    }

    public class Root
    {
        public Status Status { get; set; }
        public List<Parameter> Parameters { get; set; }
    }

    public class Status
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
