namespace Clean.WinF.Applications.Features.UIProfile
{
    public class UIProfileDto
    {
        public string MenuName { get; set; }
        public string FeatureName { get; set; }
        public string UserControlName { get; set; }
        public bool IsPermission { get; set; } = false;
        //public bool IsDisplayMessage { get; set; } = false;
        public bool IsRead { get; set; } = false;
        public bool IsExecuted { get; set; } = false;
        public bool IsInserted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
