﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vega.Persistence;
using AutoMapper;
using Vega.Controllers.Resources;
using Vega.Models;
using Microsoft.EntityFrameworkCore;

namespace Vega.Controllers
{
    [Produces("application/json")]
    [Route("api/Features")]
    public class FeaturesController : Controller
    {

        private readonly VegaDbContext context;
        private readonly IMapper mapper;


        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeaturesResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Features>, List<FeaturesResource>>(features);
        }
    }
}