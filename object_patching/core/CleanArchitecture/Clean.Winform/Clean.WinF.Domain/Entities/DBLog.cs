namespace Clean.WinF.Domain.Entities.Log
{
    //[Table("DBLog")]
    public class DBLog
    {
        public int Id { get; set; }
        public string TimeStamp { get; set; }
        public string Level { get; set; }
        public string RenderedMessage { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
        public string AppName { get; set; }
    }
}
