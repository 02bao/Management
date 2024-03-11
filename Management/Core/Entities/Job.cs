using Management.Core.Enums;

namespace Management.Core.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; }
        public Joblevel Level { get; set; }

        //Relations
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
