using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
    }
}