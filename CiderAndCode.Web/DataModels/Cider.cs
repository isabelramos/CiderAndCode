using System;

namespace CiderAndCode.Web.DataModels
{
    public class Cider
    {
        public int Id { get; set; }
        public AppleType Type { get; set; }
        public DateTime DatePressed { get; set; }
        public string TastingNotes { get; set; }
        public virtual Bushel Bushel { get; set; }
        public bool Filtered { get; set; }
        public int NumberOfGallons { get; set; }
    }
}