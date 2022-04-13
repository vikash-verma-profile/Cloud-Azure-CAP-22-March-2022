using MedicalErp.Models;
using MedicalErp.ViewModel;
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
        [HttpPost]
        [Route("AddPatientDetails")]
        [Consumes("application/x-www-form-urlencoded")]
        public string AddPatientDetails([FromForm] Patient patient )
        {
            var PatientData = new TblPatient();

            PatientData.FirstName = patient.FirstName;
            PatientData.LastName = patient.LastName;
            PatientData.Gender = patient.Gender;
            PatientData.Dob = patient.Dob;
            PatientData.CreateOn = DateTime.Now;
            PatientData.UpdatedOn = DateTime.Now;
            PatientData.IsDeleted = 0;
            _medicalERPContext.TblPatients.Add(PatientData);
            _medicalERPContext.SaveChanges();
            return "record added successfully";
        }
      
    }
}
