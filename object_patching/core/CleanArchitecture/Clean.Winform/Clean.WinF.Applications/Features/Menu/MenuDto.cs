namespace Clean.WinF.Applications.Features.Menu.DTOs
{
    public class MenuDto
    {
        public int ID { get; set; }
        public string ParentName { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string IconImg { get; set; }
        public string Desciption { get; set; }
        public string Languages { get; set; }
        public bool IsActive { get; set; }
    }
}
