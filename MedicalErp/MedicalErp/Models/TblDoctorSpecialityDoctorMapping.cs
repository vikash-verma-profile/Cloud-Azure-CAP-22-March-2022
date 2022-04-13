using System;
using System.Collections.Generic;

#nullable disable

namespace MedicalErp.Models
{
    public partial class TblDoctorSpecialityDoctorMapping
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int? SpecialityId { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
