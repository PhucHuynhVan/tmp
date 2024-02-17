namespace Clean.WinF.Applications.Features.Systems.Log
{
    public class DBLogDto
    {
        public int Id { get; set; }
        //public DateTime TimeStamp { get; set; }
        public string TimeStamp { get; set; }
        public string Level { get; set; }
        public string RenderedMessage { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
    }
}
