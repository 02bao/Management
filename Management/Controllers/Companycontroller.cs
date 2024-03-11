﻿using AutoMapper;
using Management.Core.Context;
using Management.Core.Dtos.Company;
using Management.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Companycontroller : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public Companycontroller(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        //CRUD

        //create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CompanyCreateDto([FromBody] CompanyCreateDto dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();
            return Ok("Company Created Successfully");
        }

        //Read

        //Update

        //Delete
    }
}
