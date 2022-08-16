namespace ADP.Model.Entity
{
    public class ADPTask
    {
        public Guid Id { get; set; }
        public string? Operation { get; set; }
        public long Left { get; set; }
        public long Right { get; set; }
    }
}
