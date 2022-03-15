namespace PortalJob.Domain.Entities
{
    public class Vacancy: EntityBase
    { 
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string EmailContact { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string Provice { get; set; }
        public string Description { get; set; }
        public string EmailToCV { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
