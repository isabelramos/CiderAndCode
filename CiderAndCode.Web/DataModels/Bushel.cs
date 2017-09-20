namespace CiderAndCode.Web.DataModels
{

    public class Bushel
    {
        public int Id { get; set; }
        public AppleType Type { get; set; }
        public int Quantity { get; set; }
        public bool Ripe { get; set; }
        public bool Pressed { get; set; }

        public virtual User User { get; set; }
    }

    public enum AppleType
    {
        CrabApple,
        Macintosh,
        GoldenDelicious,
        GrannySmith,
        Opal,
        PinkLady,
        HoneyCrisp
    }
}