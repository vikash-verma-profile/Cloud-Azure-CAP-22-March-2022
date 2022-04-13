using System;
using System.Collections.Generic;

#nullable disable

namespace MedicalErp.Models
{
    public partial class TblSpecialityMaster
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
