namespace PortalJob.BusinessLogic.Dtos
{
    public class VacancyDto
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string EmailContact { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string Provice { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
