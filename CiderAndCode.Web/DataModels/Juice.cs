using System;

namespace CiderAndCode.Web.DataModels
{
    public class Juice
    {
        public int Id { get; set; }
        public virtual Cider Cider { get; set; }
        public DateTime DateFiltered { get; set; }
        public bool Healthy { get; set; }
    }
}