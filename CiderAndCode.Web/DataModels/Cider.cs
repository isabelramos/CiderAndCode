using System;
using System.ComponentModel.DataAnnotations;

namespace CiderAndCode.Web.DataModels
{
    public class Cider
    {
        public int Id { get; set; }
        [Required]
        public AppleType Type { get; set; }
        public DateTime DatePressed { get; set; }
        [Required,MaxLength(500)]
        public string TastingNotes { get; set; }
        public virtual Bushel Bushel { get; set; }
        public bool Filtered { get; set; }
        public int NumberOfGallons { get; set; }
    }
}