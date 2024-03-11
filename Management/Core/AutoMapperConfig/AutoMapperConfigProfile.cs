using AutoMapper;
using Management.Core.Dtos.Company;
using Management.Core.Entities;

namespace Management.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //Company
            CreateMap<CompanyCreateDto, Company>();
            //Job

            //Candidate

        }
    }
}
