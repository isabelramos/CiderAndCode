namespace CiderAndCode.Web.DataModels
{
    public class Drink
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Cider Cider { get; set; }
        public virtual Juice Juice { get; set; }
    }
}