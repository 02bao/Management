using Management.Core.Entities;
using Management.Core.Enums;

namespace Management.Core.Dtos.Job
{
    public class JobGetDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public Joblevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
