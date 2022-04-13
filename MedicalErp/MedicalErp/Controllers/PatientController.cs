using MedicalErp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        MedicalERPContext _medicalERPContext;
        public PatientController(MedicalERPContext medicalERPContext)
        {
            _medicalERPContext = medicalERPContext;
        }
        [HttpGet]
        [Route("GetAllPatientDetails")]
        public IEnumerable<TblPatient> GetAllPatientDetails()
        {
            return _medicalERPContext.TblPatients.ToList();
        }
    }
}
