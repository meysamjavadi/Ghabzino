using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghabzino.Store
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class List
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int userId { get; set; }
        public int pspId { get; set; }
        public int owner { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string provinceId { get; set; }
        public string cityId { get; set; }
        public string reporterWarehouse { get; set; }
    }

    public class Parameters
    {
        public List<List> List { get; set; }
    }

    public class Root
    {
        public Status Status { get; set; }
        public Parameters Parameters { get; set; }
    }

    public class Status
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }


}
