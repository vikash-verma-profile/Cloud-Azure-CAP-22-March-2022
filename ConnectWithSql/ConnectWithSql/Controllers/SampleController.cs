using ConnectWithSql.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectWithSql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        SampleDBContext _sampleDBContext;
        public SampleController(SampleDBContext sampleDBContext)
        {
            _sampleDBContext = sampleDBContext;
        }
        [HttpGet]
        public IEnumerable<TblSample> GetData()
        {
            return _sampleDBContext.TblSamples.ToList();
        }
    }
}
