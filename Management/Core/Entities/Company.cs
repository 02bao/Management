using Management.Core.Enums;

namespace Management.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public Companysize Size { get; set; }

        //Relations
        public ICollection<Job> Jobs { get; set; }
    }
}
