using Management.Core.Enums;

namespace Management.Core.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; }
        public Joblevel Level { get; set; }

        public long CompanyId { get; set; }
    }
}
