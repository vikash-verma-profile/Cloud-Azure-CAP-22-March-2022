using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSql.Models;

namespace WebApplicationWithSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly SampleDbContext SampleDbContext;

        public SampleController(SampleDbContext _sampleDbContext)
        {
            SampleDbContext = _sampleDbContext;
        }

        [HttpGet]
        public IEnumerable<TblSample> Get()
        {
            return SampleDbContext.TblSamples.ToList();
        }
    }
}
