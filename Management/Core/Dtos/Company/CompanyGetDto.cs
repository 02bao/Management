using Management.Core.Enums;

namespace Management.Core.Dtos.Company
{
    public class CompanyGetDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public Companysize Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
