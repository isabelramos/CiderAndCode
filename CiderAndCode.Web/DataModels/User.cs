using System.Collections.Generic;

namespace CiderAndCode.Web.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }

        public virtual List<Bushel> Apples { get; set; }
    }

    public enum UserType
    {
        Farmer,
        Coder,
        Juicer,
        Freeloader
    }
}