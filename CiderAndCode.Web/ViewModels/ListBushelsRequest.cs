using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.ViewModels
{
    public class ListBushelsRequest
    {
        public int BushelId { get; set; }
        public AppleType Type { get; set; }
        public int Quantity { get; set; }
        public bool Ripe { get; set; }
        public bool Pressed { get; set; }
    }
}