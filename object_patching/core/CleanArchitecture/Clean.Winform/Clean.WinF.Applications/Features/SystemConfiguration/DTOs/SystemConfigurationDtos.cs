namespace Clean.WinF.Applications.Features.SystemConfiguration.DTOs
{
    public class SystemConfigurationDtos
    {
        public long ID { get; set; }
        public string FeatureKey { get; set; } // thread_menu, article_menu
        public string Permission { get; set; } // true / false
        public string MessageRet { get; set; }
    }
}
