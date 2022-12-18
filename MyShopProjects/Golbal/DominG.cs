namespace Golbal
{
    public class DominG
    {
        public long  Id { get; set; }
        public DateTime CreationDateTime { get; set; }

        public DominG()
        {
            CreationDateTime=DateTime.Now;
        }
    }
}