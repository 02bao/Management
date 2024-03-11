using AutoMapper;
using Management.Core.Context;
using Management.Core.Dtos.Job;
using Management.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public JobController( ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDto dto)
        {
            var newjob = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(newjob);
            await _context.SaveChangesAsync();

            return Ok("Job Created Successfully");
        }
    }
}
