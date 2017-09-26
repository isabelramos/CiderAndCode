using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.ViewModels
{
    public class ListBushelsResult
    {
        public int BushelId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public bool Ripe { get; set; }
        public bool Pressed { get; set; }
        public string PickerName { get; set; }
    }
}